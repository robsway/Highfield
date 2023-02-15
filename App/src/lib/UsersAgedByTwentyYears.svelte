<script lang="ts">
  import UserAgedByTwentyYears from "./UserAgedByTwentyYears.svelte"
  import { coloursSurveyStore } from "../stores/ColoursSurveyStore";

  const items = coloursSurveyStore.usersAgedByTwentyYears;
</script>

<div class="flex row flexWrap">
  <div class="flex flexWrap" style="flex: 1 1 160px">
    {#each $items as userAgedByTwentyYears}
      <UserAgedByTwentyYears dto={userAgedByTwentyYears}/>
    {/each}
  </div>
</div>
