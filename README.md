# AXL.NET
Cisco AXL API Client Library for .NET  
AXL schema version 10.0  
Get NuGet package: https://www.nuget.org/packages/AXL.NET  
More info: https://developer.cisco.com/site/axl/overview  
Example usage:  
```c#
// Add user   
var addUserResult = 
  await axlClient.ExecuteAsync(async client =>
  {
    var userId = Guid.NewGuid().ToString();
    var request = new AddUserReq
    {
      user = new XUser
      {
        userid = userId,
        userIdentity = userId,
        password = "P@ssw0rd",
        firstName = "test",
        lastName = "test"
      }
    };
    var response = await client.addUserAsync(request);
    return response.addUserResponse1.@return;
});
            
// Get users
var usersResult = 
  await axlClient.ExecuteAsync(async client =>
  {
      var request = new ListUserReq
      {
          returnedTags = new LUser { firstName = string.Empty },
          searchCriteria = new ListUserReqSearchCriteria {firstName = "%"}
      };
      var response = await client.listUserAsync(request);
      return response.listUserResponse1.@return.Select(u => u.firstName).ToList();
  });
```
