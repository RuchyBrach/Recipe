using RecipeStystem;
using System.Data;

namespace RecipeMAUI;

public partial class RecipeList : ContentPage
{
	public RecipeList()
	{
		InitializeComponent();
        this.Loaded += RecipeList_Loaded;
	}

    private void GetRecipeList()
    {
        DataTable dt = Recipe.GetRecipeList();
        RecipeLst.ItemsSource = dt.Rows;
    }

    private void RecipeList_Loaded(object? sender, EventArgs e)
    {
        GetRecipeList();
    }

}