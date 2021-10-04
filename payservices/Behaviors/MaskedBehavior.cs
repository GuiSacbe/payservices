using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace payservices.Behaviors
{
    public class MaskedBehavior : Behavior<Entry>
    {
        private string mask = string.Empty;
        IDictionary<int, char> positions;

        public void SetPositions()
        {
            if (string.IsNullOrEmpty(Mask))
            {
                positions = null;
                return;
            }

            var list = new Dictionary<int, char>();
            for (var i = 0; i < Mask.Length; i++)
            {
                if (Mask[i] != 'X')
                    list.Add(i, Mask[i]);
                positions = list;
            }
        }

        public string Mask
        {
            get => mask;
            set
            {
                mask = value;
                
            }
        }

        protected override void OnAttachedTo(Entry entry)
        {
            
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            base.OnDetachingFrom(entry);
        }

        private void OnEntryTextChanged(object sender,TextChangedEventArgs args)
        {
            var entry = sender as Entry;

            var text = entry.Text;

            if (string.IsNullOrEmpty(text) || positions == null)
                return;

            if(text.Length > mask.Length)
            {
                entry.Text = text.Remove(text.Length - 1);
                return;
            }

            foreach(var position in positions)
            {
                if(text.Length >= position.Key + 1)
                {

                }
            }
        }

        public MaskedBehavior()
        {
        }
    }
}
