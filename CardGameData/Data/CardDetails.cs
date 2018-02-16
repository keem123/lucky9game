using CardGameData.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameData.Data
{
    public class CardDetails : INotifyPropertyChanged
    {
        private bool used;
        private string cardname;
        private CardType cardtype;
        
        public bool Used { get { return used; } set { used = value; TriggerProperty("Used"); } }
        public string CardName { get { return cardname; } set { cardname = value; TriggerProperty("CardName"); } }
        public CardType CardType { get { return cardtype; } set { cardtype = value; TriggerProperty("CardType"); } }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void TriggerProperty(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

    }
}
