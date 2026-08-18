#!/usr/bin/env bash
set -euo pipefail
: "${TGVALIDATOR_API_KEY:?Set TGVALIDATOR_API_KEY}"
curl -fsS -X POST 'https://tgvalidator.com/api/v1/check' -H "X-API-Key: $TGVALIDATOR_API_KEY" -H 'Content-Type: application/json' -d '{"service_type":"tg","identifier":"+14155550100"}'
