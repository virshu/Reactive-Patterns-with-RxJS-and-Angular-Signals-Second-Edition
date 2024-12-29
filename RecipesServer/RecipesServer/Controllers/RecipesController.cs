using Microsoft.AspNetCore.Mvc;
using RecipesServer.Dtos;

namespace RecipesServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private static readonly Recipe[] recipes = [
            new Recipe
            {
                Id = 1,
                Title = "Lemon cake",
                PrepTime = 10,
                CookTime = 35,
                Servings = 10,
                Ingredients = [" 1 cup white sugar", "½ cup butter", "2 eggs", "2 teaspoons vanilla extract",
                "1 ½ cups all-purpose flour","1 ¾ teaspoons baking powder",
                "¾ cup milk",
                "1 tablespoon lemon zest",
                "1 tablespoon lemon juice"
                ],
                Steps = ["Step 1:Preheat the oven to 350 degrees F (175 degrees C). Grease a 9-inch square baking pan",
                "Step 2: Beat sugar and butter together in a mixing bowl using an electric mixer until light and fluffy. Beat in eggs and vanilla extract",
                "Step 3: Sift flour and baking powder together in a separate bowl; add to creamed mixture. Pour in milk, lemon zest, and lemon juice and mix until you achieve a smooth batter. Spoon batter into the prepared pan.",
                "Step 4: Bake in the preheated oven until a toothpick inserted into the center comes out clean, about 35 minutes."
                ],
                ImageUrl = "lemon-cake.jpg"
            },
            new Recipe
            {
   Id = 2,
    Title = "Lemon Pie",
    PrepTime = 10,
    CookTime = 35,
    Servings = 10,
    Ingredients = [" 1 cup white sugar", "½ cup butter", "2 eggs", "2 teaspoons vanilla extract",
    "1 ½ cups all-purpose flour","1 ¾ teaspoons baking powder",
    "¾ cup milk",
    "1 tablespoon lemon zest",
    "1 tablespoon lemon juice"
    ],
    Steps = ["Step 1:Preheat the oven to 350 degrees F (175 degrees C). Grease a 9-inch square baking pan",
    "Step 2: Beat sugar and butter together in a mixing bowl using an electric mixer until light and fluffy. Beat in eggs and vanilla extract",
    "Step 3: Sift flour and baking powder together in a separate bowl; add to creamed mixture. Pour in milk, lemon zest, and lemon juice and mix until you achieve a smooth batter. Spoon batter into the prepared pan.",
    "Step 4: Bake in the preheated oven until a toothpick inserted into the center comes out clean, about 35 minutes."
    ],
    ImageUrl = "lemon-pie.jpg"
             },
            new Recipe
            {
    Id = 3,
    Title = "Tortilla Wrap",
    PrepTime = 10,
    CookTime = 35,
    Servings = 10,
    Rating = 3,
    Ingredients = [" 1 cup white sugar", "½ cup butter", "2 eggs", "2 teaspoons vanilla extract",
    "1 ½ cups all-purpose flour","1 ¾ teaspoons baking powder",
    "¾ cup milk",
    "1 tablespoon lemon zest",
    "1 tablespoon lemon juice"
    ],
    Steps = ["Step 1:Preheat the oven to 350 degrees F (175 degrees C). Grease a 9-inch square baking pan",
    "Step 2: Beat sugar and butter together in a mixing bowl using an electric mixer until light and fluffy. Beat in eggs and vanilla extract",
    "Step 3: Sift flour and baking powder together in a separate bowl; add to creamed mixture. Pour in milk, lemon zest, and lemon juice and mix until you achieve a smooth batter. Spoon batter into the prepared pan.",
    "Step 4: Bake in the preheated oven until a toothpick inserted into the center comes out clean, about 35 minutes."
    ],
    ImageUrl = "tortilla-wrap.jpg"
           },
            new Recipe
            {
    Id = 4,
    Title = "Delicious Kebab",
    PrepTime = 10,
    CookTime = 35,
    Servings = 10,
    Rating = 3,
    Ingredients = [" 1 cup white sugar", "½ cup butter", "2 eggs", "2 teaspoons vanilla extract",
    "1 ½ cups all-purpose flour","1 ¾ teaspoons baking powder",
    "¾ cup milk",
    "1 tablespoon lemon zest",
    "1 tablespoon lemon juice"
    ],
    Steps = ["Step 1:Preheat the oven to 350 degrees F (175 degrees C). Grease a 9-inch square baking pan",
    "Step 2: Beat sugar and butter together in a mixing bowl using an electric mixer until light and fluffy. Beat in eggs and vanilla extract",
    "Step 3: Sift flour and baking powder together in a separate bowl; add to creamed mixture. Pour in milk, lemon zest, and lemon juice and mix until you achieve a smooth batter. Spoon batter into the prepared pan.",
    "Step 4: Bake in the preheated oven until a toothpick inserted into the center comes out clean, about 35 minutes."
    ],
    ImageUrl = "kebab.PNG"

            },
            new Recipe
            {
   Id =5,
    Title = "Chili Chicken",
    PrepTime = 10,
    CookTime = 35,
    Rating = 3,
    Servings = 10,
    Ingredients = [" 1 cup white sugar", "½ cup butter", "2 eggs", "2 teaspoons vanilla extract",
    "1 ½ cups all-purpose flour","1 ¾ teaspoons baking powder",
    "¾ cup milk",
    "1 tablespoon lemon zest",
    "1 tablespoon lemon juice"
    ],
    Steps = ["Step 1:Preheat the oven to 350 degrees F (175 degrees C). Grease a 9-inch square baking pan",
    "Step 2: Beat sugar and butter together in a mixing bowl using an electric mixer until light and fluffy. Beat in eggs and vanilla extract",
    "Step 3: Sift flour and baking powder together in a separate bowl; add to creamed mixture. Pour in milk, lemon zest, and lemon juice and mix until you achieve a smooth batter. Spoon batter into the prepared pan.",
    "Step 4: Bake in the preheated oven until a toothpick inserted into the center comes out clean, about 35 minutes."
    ],
    ImageUrl = "chicken.jpg"
            },
            new Recipe
            {
    Id = 6,
    Title = "Cookies",
    PrepTime = 10,
    CookTime = 35,
    Servings = 10,
    Rating = 3,
    Ingredients = [" 1 cup white sugar", "½ cup butter", "2 eggs", "2 teaspoons vanilla extract",
    "1 ½ cups all-purpose flour","1 ¾ teaspoons baking powder",
    "¾ cup milk",
    "1 tablespoon lemon zest",
    "1 tablespoon lemon juice"
    ],
    Steps = ["Step 1:Preheat the oven to 350 degrees F (175 degrees C). Grease a 9-inch square baking pan",
    "Step 2: Beat sugar and butter together in a mixing bowl using an electric mixer until light and fluffy. Beat in eggs and vanilla extract",
    "Step 3: Sift flour and baking powder together in a separate bowl; add to creamed mixture. Pour in milk, lemon zest, and lemon juice and mix until you achieve a smooth batter. Spoon batter into the prepared pan.",
    "Step 4: Bake in the preheated oven until a toothpick inserted into the center comes out clean, about 35 minutes."
    ],
    ImageUrl = "cookies.PNG"
            },
            new Recipe
            {
    Id = 7,
    Title = "CheeseBurger",
    PrepTime = 10,
    CookTime = 35,
    Rating = 3,
    Servings = 10,
    Ingredients = [" 1 cup white sugar", "½ cup butter", "2 eggs", "2 teaspoons vanilla extract",
    "1 ½ cups all-purpose flour","1 ¾ teaspoons baking powder",
    "¾ cup milk",
    "1 tablespoon lemon zest",
    "1 tablespoon lemon juice"
    ],
    Steps = ["Step 1:Preheat the oven to 350 degrees F (175 degrees C). Grease a 9-inch square baking pan",
    "Step 2: Beat sugar and butter together in a mixing bowl using an electric mixer until light and fluffy. Beat in eggs and vanilla extract",
    "Step 3: Sift flour and baking powder together in a separate bowl; add to creamed mixture. Pour in milk, lemon zest, and lemon juice and mix until you achieve a smooth batter. Spoon batter into the prepared pan.",
    "Step 4: Bake in the preheated oven until a toothpick inserted into the center comes out clean, about 35 minutes."
    ],
    ImageUrl = "burger.PNG"
            },
            new Recipe
            {
    Id = 8,
    Title = "Chilli Chicken",
    PrepTime = 10,
    CookTime = 35,
    Servings = 10,
    Rating = 3,
    Ingredients = [" 1 cup white sugar", "½ cup butter", "2 eggs", "2 teaspoons vanilla extract",
    "1 ½ cups all-purpose flour","1 ¾ teaspoons baking powder",
    "¾ cup milk",
    "1 tablespoon lemon zest",
    "1 tablespoon lemon juice"
    ],
    Steps = ["Step 1:Preheat the oven to 350 degrees F (175 degrees C). Grease a 9-inch square baking pan",
    "Step 2: Beat sugar and butter together in a mixing bowl using an electric mixer until light and fluffy. Beat in eggs and vanilla extract",
    "Step 3: Sift flour and baking powder together in a separate bowl; add to creamed mixture. Pour in milk, lemon zest, and lemon juice and mix until you achieve a smooth batter. Spoon batter into the prepared pan.",
    "Step 4: Bake in the preheated oven until a toothpick inserted into the center comes out clean, about 35 minutes."
    ],
    ImageUrl = "chicken.jpg"
            },
            new Recipe
            {
    Id = 9,
    Title = "Lemon cake",
    PrepTime = 10,
    CookTime = 35,
    Rating = 3,
    Servings = 10,
    Ingredients = [" 1 cup white sugar", "½ cup butter", "2 eggs", "2 teaspoons vanilla extract",
    "1 ½ cups all-purpose flour","1 ¾ teaspoons baking powder",
    "¾ cup milk",
    "1 tablespoon lemon zest",
    "1 tablespoon lemon juice"
    ],
    Steps = ["Step 1:Preheat the oven to 350 degrees F (175 degrees C). Grease a 9-inch square baking pan",
    "Step 2: Beat sugar and butter together in a mixing bowl using an electric mixer until light and fluffy. Beat in eggs and vanilla extract",
    "Step 3: Sift flour and baking powder together in a separate bowl; add to creamed mixture. Pour in milk, lemon zest, and lemon juice and mix until you achieve a smooth batter. Spoon batter into the prepared pan.",
    "Step 4: Bake in the preheated oven until a toothpick inserted into the center comes out clean, about 35 minutes."
    ],
    ImageUrl = "lemon-cake.jpg"

            },
            new Recipe
            {
   Id = 10,
    Title = "Lemon pie",
    PrepTime = 10,
    CookTime = 35,
    Rating = 3,
    Servings = 10,
    Ingredients = ["1 cup white sugar", "½ cup butter", "2 eggs", "2 teaspoons vanilla extract",
    "1 ½ cups all-purpose flour","1 ¾ teaspoons baking powder",
    "¾ cup milk",
    "1 tablespoon lemon zest",
    "1 tablespoon lemon juice"
    ],
    Steps = ["Step 1:Preheat the oven to 350 degrees F (175 degrees C). Grease a 9-inch square baking pan",
    "Step 2: Beat sugar and butter together in a mixing bowl using an electric mixer until light and fluffy. Beat in eggs and vanilla extract",
    "Step 3: Sift flour and baking powder together in a separate bowl; add to creamed mixture. Pour in milk, lemon zest, and lemon juice and mix until you achieve a smooth batter. Spoon batter into the prepared pan.",
    "Step 4: Bake in the preheated oven until a toothpick inserted into the center comes out clean, about 35 minutes."
    ],
    ImageUrl = "lemon-pie.jpg"
            },
            new Recipe
            {
   Id = 11,
    Title = "Chilli chicken",
    PrepTime = 10,
    CookTime = 35,
    Servings = 10,
    Ingredients = [" 1 cup white sugar", "½ cup butter", "2 eggs", "2 teaspoons vanilla extract",
    "1 ½ cups all-purpose flour","1 ¾ teaspoons baking powder",
    "¾ cup milk",
    "1 tablespoon lemon zest",
    "1 tablespoon lemon juice"
    ],
    Steps = ["Step 1:Preheat the oven to 350 degrees F (175 degrees C). Grease a 9-inch square baking pan",
    "Step 2: Beat sugar and butter together in a mixing bowl using an electric mixer until light and fluffy. Beat in eggs and vanilla extract",
    "Step 3: Sift flour and baking powder together in a separate bowl; add to creamed mixture. Pour in milk, lemon zest, and lemon juice and mix until you achieve a smooth batter. Spoon batter into the prepared pan.",
    "Step 4: Bake in the preheated oven until a toothpick inserted into the center comes out clean, about 35 minutes."
    ],
    ImageUrl = "chicken.jpg"
            }
        ];

        [HttpGet(Name = "GetRecipes")]
        public IEnumerable<Recipe> Get()
        {
            return recipes;
        }
    }
}
