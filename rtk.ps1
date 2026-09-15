param(
    [Parameter(ValueFromRemainingArguments = $true)]
    [string[]] $RtkArgs
)

$ErrorActionPreference = 'Stop'
$projectRoot = Split-Path -Parent $MyInvocation.MyCommand.Path
$rtkBinary = Join-Path $projectRoot '.tools\rtk.exe'

if (-not (Test-Path -LiteralPath $rtkBinary)) {
    throw "RTK binary not found: $rtkBinary"
}

$stateDirectory = Join-Path $projectRoot '.rtk\state'
New-Item -ItemType Directory -Force -Path $stateDirectory | Out-Null

$env:RTK_DB_PATH = Join-Path $stateDirectory 'history.db'
$env:RTK_RECALL_DB = Join-Path $stateDirectory 'recall.db'
$env:RTK_TELEMETRY_DISABLED = '1'

& $rtkBinary @RtkArgs
exit $LASTEXITCODE
