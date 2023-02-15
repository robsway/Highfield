<script lang="ts">
  import type { UserAgedByTwentyYearsDto } from "../types/UserAgedByTwentyYearsDto"

  export let dto: UserAgedByTwentyYearsDto;
</script>

<div class="user" style="flex: 0 0 33.3333%;">
  <img width="40" height="40" src="https://i.pravatar.cc/40?u={dto.userId}}" alt="Person"/>
  <div>
    <span>Age {dto.originalAge}</span>
    <span>(+20 {dto.agePlusTwenty})</span>
  </div>
</div>
