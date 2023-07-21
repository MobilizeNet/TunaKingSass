import { Component, ChangeDetectorRef, ElementRef
, Output, Renderer2, ViewEncapsulation} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { UserControlComponent, WebComponentsService
} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "tks-uc-ok-cancel",
   styleUrls : ["./uc-ok-cancel.component.scss"],
   templateUrl : "./uc-ok-cancel.component.html",
   encapsulation : ViewEncapsulation.None
})
@dataTransfer(["TKSucOkCancel"])
export class ucOkCancelComponent extends UserControlComponent {
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,
   changeDetector : ChangeDetectorRef,render2 : Renderer2
   ,elem : ElementRef,webComponents : WebComponentsService) {
      super(wmservice,changeDetector,render2,elem,webComponents);
   }
}