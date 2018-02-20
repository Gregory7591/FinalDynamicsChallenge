// <copyright file="PostOperationcontactCreate.cs" company="">
// Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author></author>
// <date>2/13/2018 3:33:25 PM</date>
// <summary>Implements the PostOperationcontactCreate Plugin.</summary>
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
// </auto-generated>

using System;
using System.ServiceModel;
using Microsoft.Xrm.Sdk;



namespace FinalDynamicsChallenge.contactsPlugin
{

  /// <summary>
  /// PostOperationcontactCreate Plugin.
  /// </summary>    
  public class PostOperationcontactCreate : PluginBase
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="PostOperationcontactCreate"/> class.
    /// </summary>
    /// <param name="unsecure">Contains public (unsecured) configuration information.</param>
    /// <param name="secure">Contains non-public (secured) configuration information. 
    /// When using Microsoft Dynamics 365 for Outlook with Offline Access, 
    /// the secure string is not passed to a plug-in that executes while the client is offline.</param>
    public PostOperationcontactCreate(string unsecure, string secure)
        : base(typeof(PostOperationcontactCreate))
    {

      // TODO: Implement your custom configuration handling.
    }


    /// <summary>
    /// Main entry point for he business logic that the plug-in is to execute.
    /// </summary>
    /// <param name="localContext">The <see cref="LocalPluginContext"/> which contains the
    /// <see cref="IPluginExecutionContext"/>,
    /// <see cref="IOrganizationService"/>
    /// and <see cref="ITracingService"/>
    /// </param>
    /// <remarks>
    /// For improved performance, Microsoft Dynamics 365 caches plug-in instances.
    /// The plug-in's Execute method should be written to be stateless as the constructor
    /// is not called for every invocation of the plug-in. Also, multiple system threads
    /// could execute the plug-in at the same time. All per invocation state information
    /// is stored in the context. This means that you should not use global variables in plug-ins.
    /// </remarks>
    protected override void ExecuteCrmPlugin(LocalPluginContext localContext)
    {
      if (localContext == null)
      {
        throw new InvalidPluginExecutionException("localContext");
      }
      IOrganizationService service = localContext.OrganizationService;
      IPluginExecutionContext context = localContext.PluginExecutionContext;

      if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
      {


        Entity entity = (Entity)context.InputParameters["Target"];
        if (entity.LogicalName != "contact" && context.MessageName != "Create")
        {
          return;
        }
        else
        {
          try

          {
            Entity contactTask = new Entity("task");
            contactTask["subject"] = "First follow up meeting";
            contactTask["description"] = "This is a reminder for new users to set up a follow up meeting";

            if (context.OutputParameters.Contains("id"))
            {
              Guid regardingobjectid = new Guid(context.OutputParameters["id"].ToString());
              string regardingobjectidType = "contact";
              contactTask["regardingobjectid"] = new EntityReference(regardingobjectidType, regardingobjectid);
              service.Create(contactTask);
            }
          }
          catch (FaultException ex)
          {
            throw new InvalidPluginExecutionException("An error occurred in the plug-in.", ex);
          }
        }
      }
    }
  }
}
