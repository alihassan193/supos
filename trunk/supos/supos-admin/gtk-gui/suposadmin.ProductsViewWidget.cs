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
    
    
    public partial class ProductsViewWidget {
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private Gtk.TreeView productstreeview;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget suposadmin.ProductsViewWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "suposadmin.ProductsViewWidget";
            // Container child suposadmin.ProductsViewWidget.Gtk.Container+ContainerChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.productstreeview = new Gtk.TreeView();
            this.productstreeview.CanFocus = true;
            this.productstreeview.Name = "productstreeview";
            this.productstreeview.HeadersClickable = true;
            this.GtkScrolledWindow.Add(this.productstreeview);
            this.Add(this.GtkScrolledWindow);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}
