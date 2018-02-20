// <reference path="../../../OneXrm/OneXrm.ts" include="true" />
/// <reference path="../../../OneXrm/OneXrm.Entities.contact.ts" include="true" />
var FinalDynamicsChallenge;
(function (FinalDynamicsChallenge) {
    var Forms;
    (function (Forms) {
        var contact;
        (function (contact) {
            var Contact = /** @class */ (function () {
                function Contact() {
                }
                Contact.onLoad = function (context) {
                    FinalDynamicsChallenge.Forms.contact.Contact.attachEvents(context);
                    FinalDynamicsChallenge.Forms.contact.Contact.businessRules(context, true);
                };
                Contact.onSave = function (context) { };
                Contact.attachEvents = function (context) { };
                Contact.businessRules = function (context, onLoad) {
                    if (onLoad === void 0) { onLoad = false; }
                };
                return Contact;
            }());
            contact.Contact = Contact;
        })(contact = Forms.contact || (Forms.contact = {}));
    })(Forms = FinalDynamicsChallenge.Forms || (FinalDynamicsChallenge.Forms = {}));
})(FinalDynamicsChallenge || (FinalDynamicsChallenge = {}));
window["FinalDynamicsChallenge"] = window["FinalDynamicsChallenge"] || FinalDynamicsChallenge;
window["FinalDynamicsChallenge"].Forms = window["FinalDynamicsChallenge"].Forms || FinalDynamicsChallenge.Forms;
window["FinalDynamicsChallenge"].Forms.contact = window["FinalDynamicsChallenge"].Forms.contact || FinalDynamicsChallenge.Forms.contact;
window["FinalDynamicsChallenge"].Forms.contact.Contact = window["FinalDynamicsChallenge"].Forms.contact.Event || FinalDynamicsChallenge.Forms.contact.Contact;
