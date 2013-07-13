// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace LinqTestes
{
	[Register ("LinqTestesViewController")]
	partial class LinqTestesViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITextField busca { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITableView tabela { get; set; }

		[Action ("buscar_click:")]
		partial void buscar_click (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (tabela != null) {
				tabela.Dispose ();
				tabela = null;
			}

			if (busca != null) {
				busca.Dispose ();
				busca = null;
			}
		}
	}
}
