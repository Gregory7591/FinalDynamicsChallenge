using System.Activities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;

namespace contactsWorkflows
{
  public class welcomeEmail : CodeActivity
  {
    protected override void Execute(CodeActivityContext executionContext)
    {
      ITracingService tracingService = executionContext.GetExtension<ITracingService>();
      IWorkflowContext workflowContext = executionContext.GetExtension<IWorkflowContext>();
      IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
      IOrganizationService service = executionContext.GetExtension<IOrganizationService>();

      tracingService.Trace("Creating Email");


    }


  }
}
