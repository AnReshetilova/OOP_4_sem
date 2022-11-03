using lab10.Repository;
using lab6_7;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace lab10
{
    class MainWindowViewModel : ViewModel
    {
        private ObservableCollection<Cloth> goods;
        private string name = "";
        private string price = "";
        private string description = "";
        private string color = "";
        private string picture = @"D:\вуз\4 сем\OOP_4_sem\lab6-7\resourses\0.png";
        private Cloth product;
        private string info;
        IRepository<Cloth> repository;

        public MainWindowViewModel()
        {
            goods = new ObservableCollection<Cloth>();
            repository = new ClothesRepository();
            GetGoods();
            ProductInfoCommand = new ExternalCommand(OnProductInfoCommand);
            SaveCommand = new ExternalCommand(OnSaveCommand);
            AddPictureCommand = new ExternalCommand(OnAddPictureCommand);
            DeleteCommand = new ExternalCommand(OnDeleteCommand);
        }

        public string Info
        {
            get => info;
            set => Set(ref info, value);
        }
        public string Name
        {
            get => name;
            set => Set(ref name, value);
        }
        public string Picture
        {
            get => picture;
            set
            {
                if (value.Equals(""))
                {
                    picture = @"D:\вуз\4 сем\OOP_4_sem\lab6-7\resourses\0.png";
                }
                else
                {
                    Set(ref picture, value);
                }
            }
        }
        public string Description
        {
            get => description;
            set => Set(ref description, value);
        }
        public string Color
        {
            get => color;
            set => Set(ref color, value);
        }
        public string Price
        {
            get => price;
            set => Set(ref price, value);
        }
      
        public ObservableCollection<Cloth> Goods
        {
            get => goods;
            set => Set(ref goods, value);
        }
        public ICommand ProductInfoCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand AddPictureCommand { get; }
        public ICommand ChangeLanguageCommand { get; }
        public ICommand DeleteCommand { get; }

        public ICommand ThemeCommand { get; }
        public object JsonConvert { get; private set; }

        private void OnAddPictureCommand(object o)
        {
            FileDialog fileDialog = AddPicture();
            Picture = fileDialog.FileName;
        }
        private void OnProductInfoCommand(object o)
        {
            product = o as Cloth;
            Name = product.name;
            Price = product.price;
            Color = product.color;
            Picture = product.picture;
            Description = product.description;
        }

        private void GetGoods()
        {
            Goods = new ObservableCollection<Cloth>(repository.FindAll());
        }

        private ObservableCollection<Cloth> GetGoodsByName(string name)
        {
            GetGoods();
            return new ObservableCollection<Cloth>(goods.Where(t => t.name.Contains(name)));
        }

        private void OnDeleteCommand(object o)
        {
            if (!(product is null))
            {
                product.name = Name;
                product.price = Price;
                product.color = Color;
                product.picture = Picture;
                product.description = Description;
                goods.Remove(product);
                repository.Delete(product);
            }
        }

        private void OnSaveCommand(object o)
        {
            if (name.Equals("") || Price.Equals("") || Color.Equals("") || Description.Equals(""))
            {
                Info = "Заполните все поля";
            }
            else if (!(product is null))
            {
                Info = "";
                product.name = Name;
                product.price = Price;
                product.color = Color;
                product.picture = Picture;
                product.description = Description;
                goods.Remove(product);
                goods.Add(product);
                repository.Update(product);
            }
            else
            {
                product = new Cloth();
                Info = "";
                product.name = Name;
                product.price = Price;
                product.color = Color;
                product.picture = Picture;
                product.description = Description;
                goods.Add(new Cloth() { name = Name, color = Color, price = Price, description = Description, picture = Picture });
                repository.Insert(product);
                product = null;
            }
        }

        private void SaveInfo()
        {
            
        }
    }
}

