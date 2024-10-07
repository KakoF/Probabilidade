docker compose up -d


https://grafana.com/grafana/dashboards/


Peometheus
increase(http_requests_received_total[1m])

http_requests_received_total[1m]

contadores
rate -> taxa de crescimento por segundo
rate(ultimos_sorteios[1m])*60 -> sempre melhor

ou

increase(ultimos_sorteios[1m])

gauges
cpu_usage_percentage


no ultimo minuto, quantas requisicoes em porcentagem demoraram
histogram_quantile(0.9, rate(http_request_duration_seconds_bucket[1m]))

histogram_quantile(0.9, sum by (job, le) (rate(http_request_duration_seconds_bucket[10m]))


Uma boa metrica
Total de requisicoes, que demoraram 2 segundos para ter reposta
increase(http_request_duration_seconds_bucket{le="2.048"}[1m])
sum(increase(http_request_duration_seconds_bucket{le="2.048"}[1m]))

total de requisicoes
increase(http_request_duration_seconds_count[1m])
sum(increase(http_request_duration_seconds_count[1m]))

100 * sum(increase(http_request_duration_seconds_bucket{le="2.048"}[1m])) / sum(increase(http_request_duration_seconds_count[1m]))

http://localhost:9090/graph?g0.expr=increase(http_requests_received_total%5B1m%5D)&g0.tab=0&g0.display_mode=lines&g0.show_exemplars=0&g0.range_input=1h&g1.expr=http_requests_received_total%5B1m%5D&g1.tab=0&g1.display_mode=lines&g1.show_exemplars=0&g1.range_input=1h&g2.expr=increase(ultimos_sorteios%5B1m%5D)&g2.tab=0&g2.display_mode=lines&g2.show_exemplars=0&g2.range_input=1h&g3.expr=cpu_usage_percentage&g3.tab=1&g3.display_mode=lines&g3.show_exemplars=0&g3.range_input=1h&g4.expr=histogram_quantile(0.9%2C%20rate(http_request_duration_seconds_bucket%5B1m%5D))&g4.tab=1&g4.display_mode=lines&g4.show_exemplars=0&g4.range_input=1h&g5.expr=histogram_quantile(0.9%2C%20sum%20by%20(job%2C%20le)%20(rate(http_request_duration_seconds_bucket%5B10m%5D)))&g5.tab=0&g5.display_mode=lines&g5.show_exemplars=0&g5.range_input=1h&g6.expr=increase(http_request_duration_seconds_bucket%7Ble%3D%220.512%22%7D%5B1m%5D)&g6.tab=1&g6.display_mode=lines&g6.show_exemplars=0&g6.range_input=1h&g7.expr=increase(http_request_duration_seconds_count%5B1m%5D)&g7.tab=1&g7.display_mode=lines&g7.show_exemplars=0&g7.range_input=1h&g8.expr=100%20*%20(sum(increase(http_request_duration_seconds_bucket%7Ble%3D%220.512%22%7D%5B1m%5D))%20%2F%20sum(increase(http_request_duration_seconds_count%5B1m%5D)))&g8.tab=1&g8.display_mode=lines&g8.show_exemplars=0&g8.range_input=1h