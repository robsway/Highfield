<script lang="ts">
  import FavouriteUserColour from "./FavouriteUserColour.svelte"
  import { coloursSurveyStore } from "../stores/ColoursSurveyStore";

  let items = coloursSurveyStore.favouriteColours;
</script>

{#each $items as favouriteUserColour}
  <FavouriteUserColour dto={favouriteUserColour}/>
{/each}
