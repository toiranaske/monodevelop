// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide.Gui.Dialogs {
    
    
    public partial class FeatureSelectorDialog {
        
        private Gtk.VBox vbox5;
        
        private Gtk.Label label3;
        
        private MonoDevelop.Ide.Gui.Dialogs.CombineEntryFeatureSelector featureList;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize();
            // Widget MonoDevelop.Ide.Gui.Dialogs.FeatureSelectorDialog
            this.Name = "MonoDevelop.Ide.Gui.Dialogs.FeatureSelectorDialog";
            this.Title = Mono.Unix.Catalog.GetString("New Project Features");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            // Internal child MonoDevelop.Ide.Gui.Dialogs.FeatureSelectorDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.vbox5 = new Gtk.VBox();
            this.vbox5.Name = "vbox5";
            this.vbox5.Spacing = 6;
            this.vbox5.BorderWidth = ((uint)(12));
            // Container child vbox5.Gtk.Box+BoxChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.Xalign = 0F;
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("<b>Project features</b>");
            this.label3.UseMarkup = true;
            this.vbox5.Add(this.label3);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox5[this.label3]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox5.Gtk.Box+BoxChild
            this.featureList = new MonoDevelop.Ide.Gui.Dialogs.CombineEntryFeatureSelector();
            this.featureList.Events = ((Gdk.EventMask)(256));
            this.featureList.Name = "featureList";
            this.vbox5.Add(this.featureList);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox5[this.featureList]));
            w3.Position = 1;
            w1.Add(this.vbox5);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(w1[this.vbox5]));
            w4.Position = 0;
            // Internal child MonoDevelop.Ide.Gui.Dialogs.FeatureSelectorDialog.ActionArea
            Gtk.HButtonBox w5 = this.ActionArea;
            w5.Name = "dialog1_ActionArea";
            w5.Spacing = 10;
            w5.BorderWidth = ((uint)(5));
            w5.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w6 = ((Gtk.ButtonBox.ButtonBoxChild)(w5[this.buttonCancel]));
            w6.Expand = false;
            w6.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            w5.Add(this.buttonOk);
            Gtk.ButtonBox.ButtonBoxChild w7 = ((Gtk.ButtonBox.ButtonBoxChild)(w5[this.buttonOk]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 594;
            this.DefaultHeight = 443;
            this.Show();
            this.buttonOk.Clicked += new System.EventHandler(this.OnButtonOkClicked);
        }
    }
}
