#r @"..\Farmer\bin\Debug\netstandard2.0\Farmer.dll"

open Farmer

let myFunctions = functions {
    name "isaacsuperfun"
}

let template =
    arm {
        location Helpers.Locations.``North Europe``
        resource myFunctions
    }

template
|> Writer.toJson
|> Writer.toFile @"functions.json"
