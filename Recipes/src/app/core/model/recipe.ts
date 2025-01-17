export interface Recipe {
    id?: number;
    title?: string;
    ingredients?: string;
    category?: string;
    tags?: string;
    imageUrl?: string;
    cookingTime?: number;
    prepTime?: number;
    yield?: number;
    steps?: string;
    rating?:number;
}
