using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Directory
{
    /// <summary>
    /// Lógica de interacción para DynamicUI.xaml
    /// </summary>
    public partial class DynamicUI : Window
    {
        public delegate void GetModel(IModel model, bool isNew);
        public event GetModel OnAccept;
        private IModel Model { get; set; }
        private bool isNew = true;
        public DynamicUI()
        {
            InitializeComponent();
        }

        public DynamicUI(IModel model)
            : this()
        {
            Model = model;
            isNew = false;
            //TODO: Assignar data del modelo a los campos
        }
        public void Init<T>(T model) where T : IModel, new()
        {
            
            for (int index = 0; index < model.Properties.Count; index++)
            {
                GdContainer.RowDefinitions.Add(new RowDefinition());
                var label = new Label()
                {
                    Content = string.Format("{0}:", model.Properties[index]),
                    Margin = new Thickness(10),                    
                };
                Grid.SetColumn(label, 0);
                Grid.SetRow(label, index);
                GdContainer.Children.Add(label);
            }            
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            if (OnAccept != null)
            {
                OnAccept(Model, isNew);
            }
            Close();
        }
    }
}
