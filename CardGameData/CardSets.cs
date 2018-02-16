using CardGameData.Categories;
using CardGameData.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameData
{
    public class CardSets
    {
        public ObservableCollection<CardDetails> Deck { get; set; }
        public CardSets()
        {
            Deck = new ObservableCollection<CardDetails>(new CardDetails[]
            {
                new CardDetails{  Used = false, CardName = "A", CardType = CardType.Clover },
                new CardDetails{  Used = false, CardName = "2", CardType = CardType.Clover },
                new CardDetails{  Used = false, CardName = "3", CardType = CardType.Clover },
                new CardDetails{  Used = false, CardName = "4", CardType = CardType.Clover },
                new CardDetails{  Used = false, CardName = "5", CardType = CardType.Clover },
                new CardDetails{  Used = false, CardName = "6", CardType = CardType.Clover },
                new CardDetails{  Used = false, CardName = "7", CardType = CardType.Clover },
                new CardDetails{  Used = false, CardName = "8", CardType = CardType.Clover },
                new CardDetails{  Used = false, CardName = "9", CardType = CardType.Clover },
                new CardDetails{  Used = false, CardName = "10", CardType = CardType.Clover },
                new CardDetails{  Used = false, CardName = "J", CardType = CardType.Clover },
                new CardDetails{  Used = false, CardName = "Q", CardType = CardType.Clover },
                new CardDetails{  Used = false, CardName = "K", CardType = CardType.Clover },

                new CardDetails{  Used = false, CardName = "A", CardType = CardType.Diamond },
                new CardDetails{  Used = false, CardName = "2", CardType = CardType.Diamond },
                new CardDetails{  Used = false, CardName = "3", CardType = CardType.Diamond },
                new CardDetails{  Used = false, CardName = "4", CardType = CardType.Diamond },
                new CardDetails{  Used = false, CardName = "5", CardType = CardType.Diamond },
                new CardDetails{  Used = false, CardName = "6", CardType = CardType.Diamond },
                new CardDetails{  Used = false, CardName = "7", CardType = CardType.Diamond },
                new CardDetails{  Used = false, CardName = "8", CardType = CardType.Diamond },
                new CardDetails{  Used = false, CardName = "9", CardType = CardType.Diamond },
                new CardDetails{  Used = false, CardName = "10", CardType = CardType.Diamond },
                new CardDetails{  Used = false, CardName = "J", CardType = CardType.Diamond },
                new CardDetails{  Used = false, CardName = "Q", CardType = CardType.Diamond },
                new CardDetails{  Used = false, CardName = "K", CardType = CardType.Diamond },

                new CardDetails{  Used = false, CardName = "A", CardType = CardType.Heart },
                new CardDetails{  Used = false, CardName = "2", CardType = CardType.Heart },
                new CardDetails{  Used = false, CardName = "3", CardType = CardType.Heart },
                new CardDetails{  Used = false, CardName = "4", CardType = CardType.Heart },
                new CardDetails{  Used = false, CardName = "5", CardType = CardType.Heart },
                new CardDetails{  Used = false, CardName = "6", CardType = CardType.Heart },
                new CardDetails{  Used = false, CardName = "7", CardType = CardType.Heart },
                new CardDetails{  Used = false, CardName = "8", CardType = CardType.Heart },
                new CardDetails{  Used = false, CardName = "9", CardType = CardType.Heart },
                new CardDetails{  Used = false, CardName = "10", CardType = CardType.Heart },
                new CardDetails{  Used = false, CardName = "J", CardType = CardType.Heart },
                new CardDetails{  Used = false, CardName = "Q", CardType = CardType.Heart },
                new CardDetails{  Used = false, CardName = "K", CardType = CardType.Heart },

                new CardDetails{  Used = false, CardName = "A", CardType = CardType.Spade },
                new CardDetails{  Used = false, CardName = "2", CardType = CardType.Spade },
                new CardDetails{  Used = false, CardName = "3", CardType = CardType.Spade },
                new CardDetails{  Used = false, CardName = "4", CardType = CardType.Spade },
                new CardDetails{  Used = false, CardName = "5", CardType = CardType.Spade },
                new CardDetails{  Used = false, CardName = "6", CardType = CardType.Spade },
                new CardDetails{  Used = false, CardName = "7", CardType = CardType.Spade },
                new CardDetails{  Used = false, CardName = "8", CardType = CardType.Spade },
                new CardDetails{  Used = false, CardName = "9", CardType = CardType.Spade },
                new CardDetails{  Used = false, CardName = "10", CardType = CardType.Spade },
                new CardDetails{  Used = false, CardName = "J", CardType = CardType.Spade },
                new CardDetails{  Used = false, CardName = "Q", CardType = CardType.Spade },
                new CardDetails{  Used = false, CardName = "K", CardType = CardType.Spade },
                
            });
        }
    }
}
