import { writable, type Writable } from 'svelte/store';
import type { FavouriteUserColoursDto } from '../types/FavouriteUserColoursDto';
import type { UserAgedByTwentyYearsDto } from '../types/UserAgedByTwentyYearsDto';

class ColoursSurveyStore {
    constructor(
        public favouriteColours:Writable<FavouriteUserColoursDto[]> = writable<FavouriteUserColoursDto[]>([]),
        public usersAgedByTwentyYears:Writable<UserAgedByTwentyYearsDto[]> = writable<UserAgedByTwentyYearsDto[]>([]),
    )
    {}
}

// Export a singleton
export const coloursSurveyStore = new ColoursSurveyStore();