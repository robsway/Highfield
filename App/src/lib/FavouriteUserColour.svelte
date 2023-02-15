<script lang="ts">
  import type { FavouriteUserColoursDto } from "../types/FavouriteUserColoursDto"

  export let dto: FavouriteUserColoursDto;
</script>

<div class="favouriteUserColour">
  <span class="dot" style="background-color:{dto.colour}"/>
  <span style="margin-left: 8px; vertical-align: top">{dto.colour}</span>
  <span style="margin-left: 8px; vertical-align: top">({dto.numberOfUsers})</span>
</div>
