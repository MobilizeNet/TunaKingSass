import { Component, ChangeDetectorRef, ElementRef
, Renderer2, ViewEncapsulation} from "@angular/core";
import { dataTransfer} from "@mobilize/base-components";
import { ControlContainerComponent} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "tksfrm-list-frm-listtab-page1",
   styleUrls : ["./frm-listtab-page1.component.scss"],
   templateUrl : "./frm-listtab-page1.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["TKS.frmList.tabpage.tpgOrders.tabPage1"])
export class frmListtabPage1Component extends ControlContainerComponent {
   constructor (webMapService : WebMapService,
   changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(webMapService,changeDetector,render2,elem);
   }
}