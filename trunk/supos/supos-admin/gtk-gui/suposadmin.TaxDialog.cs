// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace suposadmin {
    
    
    public partial class TaxDialog {
        
        private Gtk.Table table1;
        
        private Gtk.Entry identry;
        
        private Gtk.Label label1;
        
        private Gtk.Label label2;
        
        private Gtk.Label label3;
        
        private Gtk.Label label4;
        
        private Gtk.Entry nameentry;
        
        private Gtk.SpinButton ratespinbutton;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget suposadmin.TaxDialog
            this.Name = "suposadmin.TaxDialog";
            this.Title = Mono.Unix.Catalog.GetString("Tax");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.HasSeparator = false;
            // Internal child suposadmin.TaxDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.table1 = new Gtk.Table(((uint)(3)), ((uint)(3)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.identry = new Gtk.Entry();
            this.identry.Sensitive = false;
            this.identry.CanFocus = true;
            this.identry.Name = "identry";
            this.identry.IsEditable = true;
            this.identry.InvisibleChar = '●';
            this.table1.Add(this.identry);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.table1[this.identry]));
            w2.LeftAttach = ((uint)(1));
            w2.RightAttach = ((uint)(3));
            w2.XOptions = ((Gtk.AttachOptions)(4));
            w2.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("%");
            this.table1.Add(this.label1);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table1[this.label1]));
            w3.TopAttach = ((uint)(2));
            w3.BottomAttach = ((uint)(3));
            w3.LeftAttach = ((uint)(2));
            w3.RightAttach = ((uint)(3));
            w3.XOptions = ((Gtk.AttachOptions)(4));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.Xalign = 1F;
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("ID : ");
            this.table1.Add(this.label2);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table1[this.label2]));
            w4.XOptions = ((Gtk.AttachOptions)(4));
            w4.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.Xalign = 1F;
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("Name : ");
            this.table1.Add(this.label3);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table1[this.label3]));
            w5.TopAttach = ((uint)(1));
            w5.BottomAttach = ((uint)(2));
            w5.XOptions = ((Gtk.AttachOptions)(4));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label4 = new Gtk.Label();
            this.label4.Name = "label4";
            this.label4.Xalign = 1F;
            this.label4.LabelProp = Mono.Unix.Catalog.GetString("Rate : ");
            this.table1.Add(this.label4);
            Gtk.Table.TableChild w6 = ((Gtk.Table.TableChild)(this.table1[this.label4]));
            w6.TopAttach = ((uint)(2));
            w6.BottomAttach = ((uint)(3));
            w6.XOptions = ((Gtk.AttachOptions)(4));
            w6.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.nameentry = new Gtk.Entry();
            this.nameentry.CanFocus = true;
            this.nameentry.Name = "nameentry";
            this.nameentry.IsEditable = true;
            this.nameentry.InvisibleChar = '●';
            this.table1.Add(this.nameentry);
            Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.table1[this.nameentry]));
            w7.TopAttach = ((uint)(1));
            w7.BottomAttach = ((uint)(2));
            w7.LeftAttach = ((uint)(1));
            w7.RightAttach = ((uint)(3));
            w7.XOptions = ((Gtk.AttachOptions)(4));
            w7.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.ratespinbutton = new Gtk.SpinButton(0, 1000, 1);
            this.ratespinbutton.CanFocus = true;
            this.ratespinbutton.Name = "ratespinbutton";
            this.ratespinbutton.Adjustment.PageIncrement = 10;
            this.ratespinbutton.ClimbRate = 1;
            this.ratespinbutton.Numeric = true;
            this.table1.Add(this.ratespinbutton);
            Gtk.Table.TableChild w8 = ((Gtk.Table.TableChild)(this.table1[this.ratespinbutton]));
            w8.TopAttach = ((uint)(2));
            w8.BottomAttach = ((uint)(3));
            w8.LeftAttach = ((uint)(1));
            w8.RightAttach = ((uint)(2));
            w8.YOptions = ((Gtk.AttachOptions)(4));
            w1.Add(this.table1);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(w1[this.table1]));
            w9.Position = 0;
            w9.Expand = false;
            w9.Fill = false;
            // Internal child suposadmin.TaxDialog.ActionArea
            Gtk.HButtonBox w10 = this.ActionArea;
            w10.Name = "dialog1_ActionArea";
            w10.Spacing = 6;
            w10.BorderWidth = ((uint)(5));
            w10.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w11 = ((Gtk.ButtonBox.ButtonBoxChild)(w10[this.buttonCancel]));
            w11.Expand = false;
            w11.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w12 = ((Gtk.ButtonBox.ButtonBoxChild)(w10[this.buttonOk]));
            w12.Position = 1;
            w12.Expand = false;
            w12.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 273;
            this.DefaultHeight = 169;
            this.Show();
            this.buttonOk.Clicked += new System.EventHandler(this.OnOkClicked);
        }
    }
}
