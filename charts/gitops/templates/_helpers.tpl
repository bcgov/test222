{{- define "common.labels" -}}
{{- toYaml . | nindent 4 }}
{{- end -}}


{{- define "chart.fullname" -}}
{{- printf "%s-%s" .Release.Name .Chart.Name -}}
{{- end -}}