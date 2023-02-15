<script lang="ts">
  import { coloursSurveyStore } from "../stores/ColoursSurveyStore";
  import type { FavouriteUserColoursDto } from "../types/FavouriteUserColoursDto";
  import type { UserAgedByTwentyYearsDto } from "../types/UserAgedByTwentyYearsDto";
  import { onMount } from "svelte";

  async function getFavouriteColours():Promise<FavouriteUserColoursDto[]> {
      const response = await fetch("/api/FavouriteUserColours");

      const favouriteColours = await response.json();

      return favouriteColours as FavouriteUserColoursDto[];
  }

  async function getUsersAgedByTwentyYears():Promise<UserAgedByTwentyYearsDto[]> {
      const response = await fetch("/api/UsersAgedByTwentyYears");

      const favouriteColours = await response.json();

      return favouriteColours as UserAgedByTwentyYearsDto[];
  }

  async function resetRepository() {
    await fetch(
      "/api/ResetRepository",
      { method: "POST"});
  }

  onMount(async () => {
    
    await loadItems();

  });

  const loadItems = async () => {
    var fc = await getFavouriteColours();

    coloursSurveyStore.favouriteColours.set(fc);

    var us = await getUsersAgedByTwentyYears();

    coloursSurveyStore.usersAgedByTwentyYears.set(us);
  }

  const getNewSample = async () => {

    await resetRepository();

    await loadItems();
  }
</script>

<button on:click={getNewSample}>Get new sample</button>
