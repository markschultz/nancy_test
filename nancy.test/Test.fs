namespace nancy.test

open System
open NUnit.Framework
open Nancy.Testing
open FsUnit
open FsCheck

[<TestFixture>]
type Test() = 
    [<Test>]
    member x.TestCase() = Assert.IsTrue(true)
    [<Test>]
    member x.Test2() = "ships" |> should startWith "sh"