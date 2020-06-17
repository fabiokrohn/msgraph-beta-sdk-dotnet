// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Service Principal.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ServicePrincipal : DirectoryObject
    {
    
		///<summary>
		/// The ServicePrincipal constructor
		///</summary>
        public ServicePrincipal()
        {
            this.ODataType = "microsoft.graph.servicePrincipal";
        }
	
        /// <summary>
        /// Gets or sets account enabled.
        /// true if the service principal account is enabled; otherwise, false.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? AccountEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets add ins.
        /// Defines custom behavior that a consuming service can use to call an app in specific contexts. For example, applications that can render file streams may set the addIns property for its 'FileHandler' functionality. This will let services like Office 365 call the application in the context of a document the user is working on.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "addIns", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AddIn> AddIns { get; set; }
    
        /// <summary>
        /// Gets or sets alternative names.
        /// Used to retrieve service principals by subscription, identify resource group and full resource ids for managed identities.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "alternativeNames", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> AlternativeNames { get; set; }
    
        /// <summary>
        /// Gets or sets app description.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appDescription", Required = Newtonsoft.Json.Required.Default)]
        public string AppDescription { get; set; }
    
        /// <summary>
        /// Gets or sets app display name.
        /// The display name exposed by the associated application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string AppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets app id.
        /// The unique identifier for the associated application (its appId property).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appId", Required = Newtonsoft.Json.Required.Default)]
        public string AppId { get; set; }
    
        /// <summary>
        /// Gets or sets application template id.
        /// Unique identifier of the applicationTemplate that the servicePrincipal was created from. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicationTemplateId", Required = Newtonsoft.Json.Required.Default)]
        public string ApplicationTemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets app owner organization id.
        /// Contains the tenant id where the application is registered. This is applicable only to service principals backed by applications.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appOwnerOrganizationId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? AppOwnerOrganizationId { get; set; }
    
        /// <summary>
        /// Gets or sets app role assignment required.
        /// Specifies whether users or other service principals need to be granted an app role assignment for this service principal before users can sign in or apps can get tokens. The default value is false. Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appRoleAssignmentRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? AppRoleAssignmentRequired { get; set; }
    
        /// <summary>
        /// Gets or sets app roles.
        /// The roles exposed by the application which this service principal represents. For more information see the appRoles property definition on the application entity. Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appRoles", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AppRole> AppRoles { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for the service principal.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets error url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ErrorUrl { get; set; }
    
        /// <summary>
        /// Gets or sets homepage.
        /// Home page or landing page of the application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "homepage", Required = Newtonsoft.Json.Required.Default)]
        public string Homepage { get; set; }
    
        /// <summary>
        /// Gets or sets info.
        /// Basic profile information of the acquired application such as app's marketing, support, terms of service and privacy statement URLs. The terms of service and privacy statement are surfaced to users through the user consent experience. For more info, see How to: Add Terms of service and privacy statement for registered Azure AD apps.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "info", Required = Newtonsoft.Json.Required.Default)]
        public InformationalUrl Info { get; set; }
    
        /// <summary>
        /// Gets or sets key credentials.
        /// The collection of key credentials associated with the service principal. Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "keyCredentials", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyCredential> KeyCredentials { get; set; }
    
        /// <summary>
        /// Gets or sets login url.
        /// Specifies the URL where the service provider redirects the user to Azure AD to authenticate. Azure AD uses the URL to launch the application from Office 365 or the Azure AD My Apps. When blank, Azure AD performs IdP-initiated sign-on for applications configured with SAML-based single sign-on. The user launches the application from Office 365, the Azure AD My Apps, or the Azure AD SSO URL.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "loginUrl", Required = Newtonsoft.Json.Required.Default)]
        public string LoginUrl { get; set; }
    
        /// <summary>
        /// Gets or sets logout url.
        /// Specifies the URL that will be used by Microsoft's authorization service to logout an user using OpenId Connect front-channel, back-channel or SAML logout protocols.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "logoutUrl", Required = Newtonsoft.Json.Required.Default)]
        public string LogoutUrl { get; set; }
    
        /// <summary>
        /// Gets or sets notes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notes", Required = Newtonsoft.Json.Required.Default)]
        public string Notes { get; set; }
    
        /// <summary>
        /// Gets or sets notification email addresses.
        /// Specifies the list of email addresses where Azure AD sends a notification when the active certificate is near the expiration date. This is only for the certificates used to sign the SAML token issued for Azure AD Gallery applications.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notificationEmailAddresses", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> NotificationEmailAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets published permission scopes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "publishedPermissionScopes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<PermissionScope> PublishedPermissionScopes { get; set; }
    
        /// <summary>
        /// Gets or sets password credentials.
        /// The collection of password credentials associated with the service principal. Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordCredentials", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<PasswordCredential> PasswordCredentials { get; set; }
    
        /// <summary>
        /// Gets or sets preferred token signing key end date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "preferredTokenSigningKeyEndDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? PreferredTokenSigningKeyEndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets preferred token signing key thumbprint.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "preferredTokenSigningKeyThumbprint", Required = Newtonsoft.Json.Required.Default)]
        public string PreferredTokenSigningKeyThumbprint { get; set; }
    
        /// <summary>
        /// Gets or sets preferred single sign on mode.
        /// Specifies the single sign-on mode configured for this application. Azure AD uses the preferred single sign-on mode to launch the application from Office 365 or the Azure AD My Apps. The supported values are password, saml, external, and oidc.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "preferredSingleSignOnMode", Required = Newtonsoft.Json.Required.Default)]
        public string PreferredSingleSignOnMode { get; set; }
    
        /// <summary>
        /// Gets or sets publisher name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "publisherName", Required = Newtonsoft.Json.Required.Default)]
        public string PublisherName { get; set; }
    
        /// <summary>
        /// Gets or sets reply urls.
        /// The URLs that user tokens are sent to for sign in with the associated application, or the redirect URIs that OAuth 2.0 authorization codes and access tokens are sent to for the associated application. Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "replyUrls", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ReplyUrls { get; set; }
    
        /// <summary>
        /// Gets or sets saml metadata url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "samlMetadataUrl", Required = Newtonsoft.Json.Required.Default)]
        public string SamlMetadataUrl { get; set; }
    
        /// <summary>
        /// Gets or sets saml single sign on settings.
        /// The collection for settings related to saml single sign-on.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "samlSingleSignOnSettings", Required = Newtonsoft.Json.Required.Default)]
        public SamlSingleSignOnSettings SamlSingleSignOnSettings { get; set; }
    
        /// <summary>
        /// Gets or sets service principal names.
        /// Contains the list of identifiersUris, copied over from the associated application. Additional values can be added to hybrid applications. These values can be used to identify the permissions exposed by this app within Azure AD. For example,Client apps can specify a resource URI which is based on the values of this property to acquire an access token, which is the URI returned in the 'aud' claim.The any operator is required for filter expressions on multi-valued properties. Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "servicePrincipalNames", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ServicePrincipalNames { get; set; }
    
        /// <summary>
        /// Gets or sets service principal type.
        /// Identifies if the service principal represents an application or a managed identity. This is set by Azure AD internally. For a service principal that represents an application this is set as Application. For a service principal that represent a managed identity this is set as ManagedIdentity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "servicePrincipalType", Required = Newtonsoft.Json.Required.Default)]
        public string ServicePrincipalType { get; set; }
    
        /// <summary>
        /// Gets or sets sign in audience.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "signInAudience", Required = Newtonsoft.Json.Required.Default)]
        public string SignInAudience { get; set; }
    
        /// <summary>
        /// Gets or sets tags.
        /// Custom strings that can be used to categorize and identify the service principal. Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tags", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Tags { get; set; }
    
        /// <summary>
        /// Gets or sets token encryption key id.
        /// Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD issues tokens for this application encrypted using the key specified by this property. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tokenEncryptionKeyId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? TokenEncryptionKeyId { get; set; }
    
        /// <summary>
        /// Gets or sets app role assigned to.
        /// Principals (users, groups, and service principals) that are assigned to this service principal. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appRoleAssignedTo", Required = Newtonsoft.Json.Required.Default)]
        public IServicePrincipalAppRoleAssignedToCollectionPage AppRoleAssignedTo { get; set; }
    
        /// <summary>
        /// Gets or sets app role assignments.
        /// Applications that this service principal is assigned to. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appRoleAssignments", Required = Newtonsoft.Json.Required.Default)]
        public IServicePrincipalAppRoleAssignmentsCollectionPage AppRoleAssignments { get; set; }
    
        /// <summary>
        /// Gets or sets claims mapping policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "claimsMappingPolicies", Required = Newtonsoft.Json.Required.Default)]
        public IServicePrincipalClaimsMappingPoliciesCollectionWithReferencesPage ClaimsMappingPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets home realm discovery policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "homeRealmDiscoveryPolicies", Required = Newtonsoft.Json.Required.Default)]
        public IServicePrincipalHomeRealmDiscoveryPoliciesCollectionWithReferencesPage HomeRealmDiscoveryPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets endpoints.
        /// Endpoints available for discovery. Services like Sharepoint populate this property with a tenant specific SharePoint endpoints that other applications can discover and use in their experiences.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "endpoints", Required = Newtonsoft.Json.Required.Default)]
        public IServicePrincipalEndpointsCollectionPage Endpoints { get; set; }
    
        /// <summary>
        /// Gets or sets oauth2permission grants.
        /// Delegated permission grants authorizing this service principal to access an API on behalf of a signed-in user. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "oauth2PermissionGrants", Required = Newtonsoft.Json.Required.Default)]
        public IServicePrincipalOauth2PermissionGrantsCollectionWithReferencesPage Oauth2PermissionGrants { get; set; }
    
        /// <summary>
        /// Gets or sets member of.
        /// Roles that this service principal is a member of. HTTP Methods: GET Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "memberOf", Required = Newtonsoft.Json.Required.Default)]
        public IServicePrincipalMemberOfCollectionWithReferencesPage MemberOf { get; set; }
    
        /// <summary>
        /// Gets or sets transitive member of.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "transitiveMemberOf", Required = Newtonsoft.Json.Required.Default)]
        public IServicePrincipalTransitiveMemberOfCollectionWithReferencesPage TransitiveMemberOf { get; set; }
    
        /// <summary>
        /// Gets or sets created objects.
        /// Directory objects created by this service principal. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdObjects", Required = Newtonsoft.Json.Required.Default)]
        public IServicePrincipalCreatedObjectsCollectionWithReferencesPage CreatedObjects { get; set; }
    
        /// <summary>
        /// Gets or sets license details.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "licenseDetails", Required = Newtonsoft.Json.Required.Default)]
        public IServicePrincipalLicenseDetailsCollectionPage LicenseDetails { get; set; }
    
        /// <summary>
        /// Gets or sets owners.
        /// Directory objects that are owners of this servicePrincipal. The owners are a set of non-admin users or servicePrincipals who are allowed to modify this object. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "owners", Required = Newtonsoft.Json.Required.Default)]
        public IServicePrincipalOwnersCollectionWithReferencesPage Owners { get; set; }
    
        /// <summary>
        /// Gets or sets owned objects.
        /// Directory objects that are owned by this service principal. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ownedObjects", Required = Newtonsoft.Json.Required.Default)]
        public IServicePrincipalOwnedObjectsCollectionWithReferencesPage OwnedObjects { get; set; }
    
        /// <summary>
        /// Gets or sets token issuance policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tokenIssuancePolicies", Required = Newtonsoft.Json.Required.Default)]
        public IServicePrincipalTokenIssuancePoliciesCollectionWithReferencesPage TokenIssuancePolicies { get; set; }
    
        /// <summary>
        /// Gets or sets token lifetime policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tokenLifetimePolicies", Required = Newtonsoft.Json.Required.Default)]
        public IServicePrincipalTokenLifetimePoliciesCollectionWithReferencesPage TokenLifetimePolicies { get; set; }
    
        /// <summary>
        /// Gets or sets synchronization.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "synchronization", Required = Newtonsoft.Json.Required.Default)]
        public Synchronization Synchronization { get; set; }
    
    }
}

