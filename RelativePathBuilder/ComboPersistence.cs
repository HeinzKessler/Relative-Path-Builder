using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelativePathBuilder
{
    static class ComboPersistence
    {
        public static void LoadMRUListFromSettings( this ComboBox combo, StringCollection settingsMRUList )
        {
            if( settingsMRUList != null )
            {
                combo.SetMRUList( settingsMRUList.Cast<string>() );
            }
        }

        const int _maxMRUCount = 20;

        public static IEnumerable<string> GetMRUList( this ComboBox combo )
        {
            AddCurrentComboTextToMRU( combo );
            return combo.Items.Cast<string>().Take( _maxMRUCount ).Where( i => !string.IsNullOrEmpty( i ) ).ToList();
        }

        public static void AddCurrentComboTextToMRU( this ComboBox combo )
        {
            if( combo.Text == "" )
            {
                return;
            }
            var textIndexInCombo = combo.Items.IndexOf( combo.Text );
            var t = combo.Text;

            if( textIndexInCombo >= 0 )
            {
                combo.Items.RemoveAt( textIndexInCombo );
            }
            combo.Items.Insert( 0, t );
            combo.Text = t;
        }

        public static void SetMRUList( this ComboBox combo, IEnumerable<string> mru )
        {
            combo.Items.Clear();
            combo.Items.AddRange( mru.Where( i => !string.IsNullOrEmpty( i ) ).ToArray() );
            if( combo.Items.Count > 0 )
            {
                combo.SelectedIndex = 0;
            }
        }
    }
}
