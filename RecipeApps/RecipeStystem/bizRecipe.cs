
using System.Data;
using System.Data.SqlClient;

namespace RecipeSystem
{
    public class bizRecipe : bizObject<bizRecipe>
    {
        private int _recipeid;
        private int _hhuserid;
        private int _cuisineid;
        private string _recipename = "";
        private int _calories = 0;
        private DateTime _datetimedraft;
        private DateTime? _datetimepublished;
        private DateTime? _datetimearchived;
        private string _recipestatus = "";
        private string _recipepic = "";
        private bool _vegan;
        private string _username = "";
        private int _numingredients;
        private string _cookbookname = "";

        public List<bizRecipe> Search(string recipenameval)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(this.GetSprocName);
            SQLUtility.SetParamValue(cmd, "RecipeName", recipenameval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public List<bizRecipe> GetByCookBook(string cookbooknameval)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGetByCookBook");
            SQLUtility.SetParamValue(cmd, "CookBookName", cookbooknameval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }
        public List<bizRecipe> GetByCuisine(int cuisineidval)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGetByCuisine");
            SQLUtility.SetParamValue(cmd, "CuisineId", cuisineidval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }
        public int RecipeId
        {
            get => _recipeid;
            set
            {
                if(_recipeid != value)
                {
                    _recipeid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int HHUserId
        {
            get => _hhuserid;
            set
            {
                if(_hhuserid!= value)
                {
                    _hhuserid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int CuisineId
        {
            get => _cuisineid;
            set
            {
                if(_cuisineid != value)
                {
                    _cuisineid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string RecipeName
        {
            get => _recipename;
            set
            {
                if(_recipename != value)
                {
                    _recipename = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int Calories
        {
            get => _calories;
            set
            {
                if(_calories != value)
                {
                    _calories = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DateTimeDraft
        {
            get => _datetimedraft;
            set
            {
                if(_datetimedraft != value)
                {
                    _datetimedraft = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime? DateTimePublished
        {
            get => _datetimepublished;
            set
            {
                if(_datetimepublished != value)
                {
                    _datetimepublished = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime? DateTimeArchived
        {
            get => _datetimearchived;
            set
            {
                if(_datetimearchived != value)
                {
                    _datetimearchived = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string RecipeStatus
        {
            get => _recipestatus;
            set
            {
                if (_recipestatus != value)
                {
                    _recipestatus = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string RecipePic
        {
            get => _recipepic;
            set
            {
                if (_recipepic != value)
                {
                    _recipepic = value;
                    InvokePropertyChanged();
                }
            }
        }
        public bool Vegan
        {
            get => _vegan;
            set
            {
                if (_vegan != value)
                {
                    _vegan = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string UserName
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int NumIngredients
        {
            get => _numingredients;
            set
            {
                if (_numingredients != value)
                {
                    _numingredients = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string CookBookName
        {
            get => _cookbookname;
            set
            {
                if (_cookbookname != value)
                {
                    _cookbookname = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
