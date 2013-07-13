using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Net;
using System.Collections.Generic;
using System.Linq;

namespace LinqTestes
{
    public class TableSource : UITableViewSource
    {
        string cellIdentifier = "Nomes";
        String[] tableItems;
        public TableSource (String[] items)
        {
            tableItems = items;
        }
        public override int RowsInSection (UITableView tableview, int section)
        {
            return tableItems.Count();
        }
        public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell (cellIdentifier);

            if (cell == null)
                cell = new UITableViewCell (UITableViewCellStyle.Default, cellIdentifier);
            cell.TextLabel.Text = tableItems[indexPath.Row];
            return cell;
        }
    }

    public partial class LinqTestesViewController : UIViewController
    {
        private List<String> nomes;

        public LinqTestesViewController() : base ("LinqTestesViewController", null)
        {
            this.nomes = new List<string>
            {
                "Breno",
                "Giovanni",
                "Victor Cavalcante",
                "Juliano",
                "Fernando",
                "Victor Hugo",
                "Vinicius Hana",
                "Vinicius Moura"
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();
            
            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            this.tabela.Source = new TableSource(this.nomes.ToArray());
            base.ViewDidLoad();
        }

        public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
        {
            // Return true for supported orientations
            return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
        }

        partial void buscar_click (MonoTouch.Foundation.NSObject sender)
        {
            var busca = this.busca.Text;

            var dados = this.nomes.Where(n => n.Contains(busca));

            this.tabela.Source = new TableSource(dados.ToArray());
            this.tabela.ReloadData();
        }
    }
}

