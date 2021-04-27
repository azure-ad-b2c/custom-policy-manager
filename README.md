# Manage custom polices in Azure AD B2C using Graph API

This is a sample management tool for B2C Custom Policies.  [Custom policy](https://docs.microsoft.com/en-us/azure/active-directory-b2c/active-directory-b2c-overview-custom) allows you to customize every aspect of the authentication flow.

## Features

This sample demonstrates the following:

* **Create** a custom policy
* **Update** a custom policy
* **Delete** a custom policy
* **List** all custom policies

    ![Policy Manager](/Images/b2cpolicymanager.PNG)

## Getting Started

### Prerequisites

This sample requires the following:
* [Visual Studio](https://www.visualstudio.com/en-us/downloads)
* [Azure AD B2C tenant](https://docs.microsoft.com/en-us/azure/active-directory-b2c/active-directory-b2c-get-started)

**NOTE: This API only accepts user tokens, and not application tokens. See more information below about Delegated Permissions.**

### Quickstart

#### Create global administrator

* A global administrator account is required to run admin-level operations and to consent to application permissions.  (for example: admin@myb2ctenant.onmicrosoft.com)

#### Setup and usage

1. Sign in to the [Azure Portal](https://portal.azure.com/) using your Global Admin account.
2.  Select your Azure AD B2C directory from the directory filter.
3. Select the **Azure Active Directory Blade**.
4. Select **Application Registrations**, and then select **New registration**.
5. Enter a Name for the application of your choice and then under **Supported account types**, select either **Accounts in this organizational directory only(Single tenant)** or **Accounts in any organizational directory(Multitenant)**.
6. Under **Redirect URI**, select **Native**, and then enter `https://b2capi.com` and then click on **Register** button.
7. Once the app registration is successful, select it and under **Manage** click on  **API permissions**.
8. Click on **Add a permission** and select **Microsoft Graph**.  Under delegated permission select **Read and write your organization's trust framework policies**.
9. Click **Save**, and click **Grant admin consent**.
10. Select the **Azure AD B2C Blade** in your Azure AD B2C directory.
11. Select **Application Registrations**, and then select **New registration**.
12. Enter a Name for the application of your choice and then under **Supported account types**, leave the default selection as it is. That is,  **Accounts in any identity provider or organizational directory (for authenticating users with user flows)**.
13. Under **Redirect URI**, select **Web**, and then enter ``https://jwt.ms``. Click on **Register** button.
14. Open and build the solution in Visual Studio. 
15. Run the application:
    
    a. Set the Tenant to your B2C tenant: something.onmicrosoft.com

    b. Set the V1 Graph App Id to the Application Id from the App Registration created in the AAD Blade in Step 6.

    c. Set the B2C Application Id to the App Id of an Application Registration created in the AAD B2C Blade in Step 13.

    d. Set the reply url to a valid Reply URL set on the Application Registration referenced in Step 13 (https://jwt.ms).

1. Click Login and login with the Global Admin of your B2C tenant. It must be in the format user@something.onmicrosoft.com.

After logging in, any custom policies registered in the Identity Experience Framework at the portal or uploaded by this tool will be listed.

Select a Policy Folder that contains your XML files to upload them.

You can also open the working folder in VSCode by clicking Open Folder in VSCode.

## Usage tips
- Initial Usage  
  - Select your working folder using the **Select Policy Folder** button.  

  - Select Policy files to Upload into your Azure AD B2C tenant.  

  - Click **Update Policies** to write the policy files into the tenant.  
  - Use the **Log** area to troubleshoot any syntax errors.
  - Once the policies are uploaded, they will appear in the List of policies. 

  - Select a Policy in the list of policies and click **Launch with IE** to test it.

- Select **Only show RPs** to only show the Relying Party files in the Polices list. You must **List Policies** for this to update the list based on the selection.
- Select a Policy and click **Delete Policy** to delete the policy from the tenant.
- Select **Delete all policies** to delete all policies in this tenant.
- Select **Get Access token** if you would like to also acquire an access token. This will only work if **B2C Resource** is not null. Enter the scopes into the **B2C Resource** text field.
- To launch a policy, select the Relying Party file from the policy list, and then click **Launch with IE** or **Launch with Chrome**. Both options will open an private window.
- To test a SAML Relying Party, click the **SAML SP** button. This will use a test site (https://b2csamlrp.azurewebsites.net/SP/) to build a SAML request for your B2C Policy to the authentication endpoint. The b2csamlrp will also parse the resulting SAML Assertion from B2C.

## Questions and comments

Questions about this sample should be posted to [Stack Overflow](https://stackoverflow.com/questions/tagged/azure-ad-b2c). Make sure that your questions or comments are tagged with [azure-ad-b2c].

## Contributing

If you'd like to contribute to this sample, see [CONTRIBUTING.MD](/CONTRIBUTING.md).

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## Resources

The sample uses the Active Directory Authentication Library (ADAL) for authentication. The sample demonstrates delegated admin permissions. (App only permissions are not supported yet)

**Delegated permissions** are used by apps that have a signed-in user present (in this case tenant administrator). For these apps either the user or an administrator consents to the permissions that the app requests and the app is delegated permission to act as the signed-in user when making calls to Microsoft Graph. Some delegated permissions can be consented to by non-administrative users, but some higher-privileged permissions require administrator consent.

See [Delegated permissions, Application permissions, and effective permissions](https://developer.microsoft.com/en-us/graph/docs/concepts/permissions_reference#delegated-permissions-application-permissions-and-effective-permissions) for more information about these permission types.
