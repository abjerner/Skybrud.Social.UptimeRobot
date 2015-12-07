Skybrud.Social.UptimeRobot
=======================

[Uptime Robot](https://uptimerobot.com/) is a service that let's you monitor a given HTTP(s) URL, port number or similar. **Skybrud.Social.UptimeRobot** is an implementation of the Uptime Robot API.

## Usage

Communication with the Uptime Robot API starts with the `UptimeRobotService`. You can initialize a new instance of this class like:

```C#
UptimeRobotService service = UptimeRobotService.CreateFromApiKey("your api key");
```

You can find your API key under your [Uptime Robot Settings](https://uptimerobot.com/dashboard.php#mySettings).

**Get accounts details** 
You can get the details of your account/user like shown in this Razor example:

```C#
UptimeRobotGetAccountDetailsResponse response = service.Accounts.GetAccountDetails();
    
<p>Monitor limit: @response.Body.Account.MonitorLimit</p>
<p>Monitor interval: @response.Body.Account.MonitorInterval</p>
<p>Monitors currently up: @response.Body.Account.UpMonitors</p>
<p>Monitors currently down: @response.Body.Account.DownMonitors</p>
<p>Monitors currently paused: @response.Body.Account.PausedMonitors</p>
```

**Get a list of monitors** 
You can also get a list of your monitors like in the example below:

```C#
UptimeRobotGetMonitorsResponse response = service.Monitors.GetMonitors();
    
foreach (var monitor in response.Body.Monitors) {
        
    <p>@monitor.FriendlyName: @monitor.Status (@String.Format("{0:0.00}", monitor.AlltimeUptimeRatio) %)</p>
        
}
```

The response is paginated, and will return a maximum of 50 monitors per page. You can explore the `UptimeRobotGetMonitorsOptions` class for further options - including pagination:

```C#
UptimeRobotGetMonitorsOptions options = new UptimeRobotGetMonitorsOptions {
    Offset = 25,
    Limit = 25,
    Logs = true
};

UptimeRobotGetMonitorsResponse response = service.Monitors.GetMonitors(options);
```

The Uptime Robot currently has more options than available in this implementation.