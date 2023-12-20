using System.Net;

HttpListener server = new HttpListener();
const int port = 8080;

//http://localhost:8080/
server.Prefixes.Add("http://*:" + port.ToString() + "/");
server.Start();
Console.WriteLine($"Server started on {port} port");

while (true)
{
    var context = await server.GetContextAsync();

    if (context.Request.HttpMethod == HttpMethod.Get.Method)
    {
        using var resp = context.Response;
        context.Response.StatusCode = (int)HttpStatusCode.OK;
    }
}