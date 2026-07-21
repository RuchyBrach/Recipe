using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizMeal : bizObject<bizMeal>
    {
        private int _mealid;
        private int _hhuserid;
        private string _mealname = "";
        private DateTime _mealdatecreated;
        private bool _mealactive;
        private string _mealpic = "";
        private string _mealdesc = "";
        private string _username = "";
        private int _numcalories;
        private int _numcourses;
        private int _numrecipes;

        public int MealId
        {
            get => _mealid;
            set
            {
                if(_mealid != value)
                {
                    _mealid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int HHUserId
        {
            get => _hhuserid;
            set
            {
                if (_hhuserid != value)
                {
                    _hhuserid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string MealName
        {
            get => _mealname;
            set
            {
                if (_mealname != value)
                {
                    _mealname = value;
                    InvokePropertyChanged();
                }
            }
        }
        public DateTime MealDateCreated
        {
            get => _mealdatecreated;
            set
            {
                if (_mealdatecreated != value)
                {
                    _mealdatecreated = value;
                    InvokePropertyChanged();
                }
            }
        }
        public bool MealActive
        {
            get => _mealactive;
            set
            {
                if (_mealactive != value)
                {
                    _mealactive = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string MealPic
        {
            get => _mealpic;
            set
            {
                if (_mealpic != value)
                {
                    _mealpic = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string MealDesc
        {
            get => _mealdesc;
            set
            {
                if (_mealdesc != value)
                {
                    _mealdesc = value;
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
        public int NumCalories
        {
            get => _numcalories;
            set
            {
                if (_numcalories != value)
                {
                    _numcalories = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int NumCourses
        {
            get => _numcourses;
            set
            {
                if (_numcourses != value)
                {
                    _numcourses = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int NumRecipes
        {
            get => _numrecipes;
            set
            {
                if (_numrecipes != value)
                {
                    _numrecipes = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
