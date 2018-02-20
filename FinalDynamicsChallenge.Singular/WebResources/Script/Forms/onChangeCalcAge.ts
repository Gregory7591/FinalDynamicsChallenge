// <reference path="../../../OneXrm/OneXrm.ts" include="true" />
/// <reference path="../../../OneXrm/OneXrm.Entities.contact.ts" include="true" />

module FinalDynamicsChallenge {
  export module Forms {
    export module contact {
      export class Contact {
        public static onLoad(context: Xrm.Page.EventContext): void {
          FinalDynamicsChallenge.Forms.contact.Contact.attachEvents(context);
          FinalDynamicsChallenge.Forms.contact.Contact.businessRules(context, true);
        }

        public static onSave(context: Xrm.Page.EventContext): void { }

        private static attachEvents(context: Xrm.Page.EventContext): void { }

        private static businessRules(context: Xrm.Page.EventContext, onLoad: boolean = false): void { }
      }
    }
  }
}

window["FinalDynamicsChallenge"] = window["FinalDynamicsChallenge"] || FinalDynamicsChallenge;
window["FinalDynamicsChallenge"].Forms = window["FinalDynamicsChallenge"].Forms || FinalDynamicsChallenge.Forms;
window["FinalDynamicsChallenge"].Forms.contact = window["FinalDynamicsChallenge"].Forms.contact || FinalDynamicsChallenge.Forms.contact;
window["FinalDynamicsChallenge"].Forms.contact.Contact = window["FinalDynamicsChallenge"].Forms.contact.Event || FinalDynamicsChallenge.Forms.contact.Contact;