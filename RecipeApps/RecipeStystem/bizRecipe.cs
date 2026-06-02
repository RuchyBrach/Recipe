
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

        public List<bizRecipe> Search(string recipenameval)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(this.GetSprocName);
            SQLUtility.SetParamValue(cmd, "RecipeName", recipenameval);
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
    }
}
