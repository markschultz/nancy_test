﻿namespace nancy.test

open System
open NUnit.Framework

[<TestFixture>]
type Test() = 
    [<Test>]
    member x.TestCase() = Assert.IsTrue(true)

