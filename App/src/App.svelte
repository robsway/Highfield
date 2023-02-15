<script lang="ts">
  import Controls from './lib/Controls.svelte'
  import FavouriteUserColours from './lib/FavouriteUserColours.svelte'
  import UsersAgedByTwentyYears from './lib/UsersAgedByTwentyYears.svelte'
</script>

<main>

  <h3>Highfield favourite user colours survey</h3>

  <div class="flex row" style="width: 100%">

    <div class="card flex col" style="flex: 25%">
      <h3>Favourite colours</h3>
      <FavouriteUserColours />
    </div>

    <div class="card flex col" style="mergin-left: 8px; flex: 75%">
      <h3>Contributing users</h3>
      <UsersAgedByTwentyYears />
    </div>

  </div>

  <Controls />

</main>
