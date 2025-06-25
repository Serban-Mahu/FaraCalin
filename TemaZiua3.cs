
/*if (deviceState.Trim().ToLower() == "ready" ||
    deviceState.Trim().ToLower() == "busy" ||
    deviceState.Trim().ToLower() == "error")
{
    // Device state is valid
}
else
{
    TheExec.Datalog.WriteComment("Variable 'deviceState' must be 'ready', 'busy' or 'error'");
    return tlResult_Module.TL_ERROR;
)
*/

int error = 1;
string deviceState = "unknown";
Console.WriteLine($"Error {error}");
Console.WriteLine($"Variable 'deviceState' is {deviceState} and it should be ready, busy or error ");




/*if (userRole.Trim().ToLower() == "admin" ||
    userRole.Trim().ToLower() == "operator" ||
    userRole.Trim().ToLower() == "viewer")
{
    // Role is valid
}
else
{
    TheExec.Datalog.WriteComment("Variable 'userRole' must be 'admin', 'operator' or 'viewer'");
    return tlResult_Module.TL_ERROR;
}
*/


int error2 = 2;
string userRole = "ready";
Console.WriteLine($"Error {error2}");
Console.WriteLine($"Variable 'userRole' is {userRole} and it should be admin, operator or viewer);


/*if (testMode.Trim().ToLower() == "normal" ||
    testMode.Trim().ToLower() == "debug" ||
    testMode.Trim().ToLower() == "safe")
{
    // Do nothing
}
else
{
    TheExec.Datalog.WriteComment("Variable 'testMode' must be 'normal', 'debug' or 'safe'");
    return tlResult_Module.TL_ERROR;
}
*/

int error3 = 3;
string testMode = "wrong";
Console.WriteLine($"Error {error3}");
Console.WriteLine($"Variable 'testMode' is {testMode} and it should be normal, debug or safe");
Console.ReadKey();