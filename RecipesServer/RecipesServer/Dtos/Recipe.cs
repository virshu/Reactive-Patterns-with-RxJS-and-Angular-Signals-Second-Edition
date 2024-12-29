namespace RecipesServer.Dtos
{
    public struct Recipe
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string[] Ingredients { get; set; }
        public string? Tags { get; set; }
        public string? ImageUrl { get; set; }
        public string[] Steps { get; set; }
        public int CookTime{ get; set; }
        public int PrepTime { get; set; }
        public int Servings { get; set; }
        public int Yield { get; set; }
        public int Rating { get; set; }
    }
}
