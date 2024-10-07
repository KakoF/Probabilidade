
# Análise de Métricas de Latência

## 1. Endpoint: Loteria/Get

### Dados principais
- **Soma total de latência:** 6.7069318 segundos
- **Número total de requisições:** 69.374

### Latência média
A latência média das requisições é calculada da seguinte forma:

\[
\text{Latência Média} = \frac{6.7069318 \, \text{segundos}}{69.374 \, \text{requisições}} \approx 0.0000967 \, \text{segundos} \, (ou \, 0.0967 \, ms)
\]

### Buckets de latência
- **69280 requisições** em **até 1ms**
- **69332 requisições** em **até 2ms**
- **69361 requisições** em **até 8ms**
- **69373 requisições** em **até 16ms**
- **69374 requisições** em **até 256ms**
- **69374 requisições** em **até 512ms**
- **69374 requisições** em **até 1 segundo**
- **69374 requisições** em **até 2 segundos**
- **69374 requisições** em **até 4 segundos**
- **69374 requisições** em **até 8 segundos**

### Percentis aproximados
- **p50 (Mediana):** menos de 1ms
- **p90:** menos de 2ms
- **p95:** menos de 4ms
- **p99:** menos de 4ms

### Conclusão
O endpoint **"Loteria/Get"** apresenta uma excelente latência média de **0.0967 ms**, com a maioria das requisições (p50) completadas em menos de **1ms**.

---

## 2. Endpoint: Sorteio/{loteria}/ultimos

### Dados principais
- **Soma total de latência:** 6173.4944 segundos
- **Número total de requisições:** 40.184

### Latência média
A latência média das requisições é calculada da seguinte forma:

\[
\text{Latência Média} = \frac{6173.4944 \, \text{segundos}}{40184 \, \text{requisições}} \approx 0.1535 \, \text{segundos} \, (ou \, 153.5 \, ms)
\]

### Buckets de latência
- **0 requisições** em **até 1ms**
- **0 requisições** em **até 2ms**
- **31 requisições** em **até 4ms**
- **3199 requisições** em **até 8ms**
- **6595 requisições** em **até 16ms**
- **37574 requisições** em **até 256ms**
- **39011 requisições** em **até 512ms**
- **39607 requisições** em **até 1 segundo**
- **40127 requisições** em **até 2 segundos**
- **40184 requisições** em **até 4 segundos**

### Percentis aproximados
- **p50 (Mediana):** cerca de 256ms
- **p90:** até 512ms
- **p95:** até 1 segundo
- **p99:** até 2 segundos

### Conclusão
A latência média do endpoint **"Sorteio/{loteria}/ultimos"** é de **153.5 ms**, com uma distribuição de latências indicando que, embora uma parte significativa das requisições seja concluída rapidamente, há algumas que demoram mais, afetando a experiência do usuário.
