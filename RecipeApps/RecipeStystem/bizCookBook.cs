using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RecipeSystem
{
    public class bizCookBook : bizObject<bizCookBook>
    {
        private int _cookbookid;
        private int _hhuserid;
        private string _cookbookname = "";
        private decimal _price;
        private DateTime _cookbookdatecreated;
        private bool _cookbookactive;
        private string _cookbookpic = "";
        private int _cookbookskill;
        private string _cookbookskilldesc = "";
        private string _username = "";
        private int _numrecipes;

        public int CookBookId
        {
            get => _cookbookid;
            set
            {
                if(_cookbookid != value)
                {
                    _cookbookid = value;
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
        public decimal Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    InvokePropertyChanged();
                }
            }
        }
        public DateTime CookBookDateCreated
        {
            get => _cookbookdatecreated;
            set
            {
                if (_cookbookdatecreated != value)
                {
                    _cookbookdatecreated = value;
                    InvokePropertyChanged();
                }
            }
        }
        public bool CookBookActive
        {
            get => _cookbookactive;
            set
            {
                if (_cookbookactive != value)
                {
                    _cookbookactive = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string CookBookPic
        {
            get => _cookbookpic;
            set
            {
                if (_cookbookpic != value)
                {
                    _cookbookpic = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int CookBookSkill
        {
            get => _cookbookskill;
            set
            {
                if (_cookbookskill != value)
                {
                    _cookbookskill = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string CookBookSkillDesc
        {
            get => _cookbookskilldesc;
            set
            {
                if (_cookbookskilldesc != value)
                {
                    _cookbookskilldesc = value;
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
