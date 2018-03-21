namespace AwsDotnetFsharp
open Amazon.Lambda.Core

[<assembly:LambdaSerializer(typeof<Amazon.Lambda.Serialization.Json.JsonSerializer>)>]
do ()

type Request = { Data : string }
type Response = { Message : string; Request : Request }

module Handler2 =
    let hello(request:Request) =
        { Message="My first F# serverless on .netcore 2.1 is working!"
          Request=request }
