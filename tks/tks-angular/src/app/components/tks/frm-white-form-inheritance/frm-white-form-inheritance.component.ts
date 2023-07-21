import { Component, ChangeDetectorRef, ElementRef
, Output, Renderer2, ViewEncapsulation} from "@angular/core";
import { EventData, dataTransfer} from "@mobilize/base-components";
import { FormComponent} from "@mobilize/winforms-components";
import { WebMapService} from "@mobilize/angularclient";
@Component({
   selector : "tks-frm-white-form-inheritance",
   styleUrls : ["./frm-white-form-inheritance.component.scss"],
   templateUrl : "./frm-white-form-inheritance.component.html",
   encapsulation : ViewEncapsulation.None
})
export class frmWhiteFormInheritanceComponent extends FormComponent {
   protected webServices : WebMapService;
   constructor (wmservice : WebMapService,
   changeDetector : ChangeDetectorRef,render2 : Renderer2,elem : ElementRef) {
      super(wmservice,changeDetector,render2,elem);
   }
}