$WhatIf = $false

Get-ChildItem -Recurse -Filter *.cs | ForEach-Object {
    $path = $_.FullName
    $content = Get-Content $path -Raw

    if ($content -match 'NetFabric\.Hyperlinq') {
        if ($WhatIf) {
            Write-Host "Was changed: $path"
        } else {
            $newContent = $content -replace 'NetFabric\.Hyperlinq', 'Hopeful.Hyperlinq'
            [IO.File]::WriteAllText($path, $newContent, [System.Text.Encoding]::UTF8)
            Write-Host "Changed: $path"
        }
    }
}
