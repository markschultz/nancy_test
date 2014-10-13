namespace nancy_test
open Nancy

type HomeModule() as x =
    inherit NancyModule()
    let IsPjax = false
    do x.Get.["/home/"] <- fun _ -> box x.View.["HomeIndex"]
    do x.Get.["/home/first/"] <- fun _ -> box x.View.["First"]
    do x.Get.["/home/second/"] <- fun _ -> box x.View.["Second"]
