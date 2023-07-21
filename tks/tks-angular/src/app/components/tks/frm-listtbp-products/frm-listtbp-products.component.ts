import { Component, ChangeDetectorRef, ElementRef
, Renderer2, ViewEncapsulation} from "@angular/core";
import { dataTransfer} from "@mobilize/base-components";
import { ControlContainerComponent} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "tksfrm-list-frm-listtbp-products",
   styleUrls : ["./frm-listtbp-products.component.scss"],
   templateUrl : "./frm-listtbp-products.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["TKS.frmList.tabpage.tpgOrders.tbpProducts"])
export class frmListtbpProductsComponent extends ControlContainerComponent {
   constructor (webMapService : WebMapService,
   changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(webMapService,changeDetector,render2,elem);
   }
}