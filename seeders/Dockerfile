FROM mongo

COPY diadesorte.json DiadeSorte.json
COPY duplasena.json DuplaSena.json
COPY federal.json Federal.json
COPY lotofacil.json LotoFacil.json
COPY lotomania.json LotoMania.json
COPY maismilionaria.json MaisMilionaria.json
COPY megasena.json MegaSena.json
COPY quina.json Quina.json
COPY supersete.json SuperSete.json
COPY timemania.json TimeMania.json

CMD ls -1 *.json | while read jsonfile; do mongoimport --host mongodb --db probabilidade-loteria --collection ${jsonfile%%.*} --username loterias_admin --password loterias_admin_1234 --authenticationDatabase=admin --file $jsonfile --jsonArray --type json; done

#${jsonfile##*/} 
#${jsonfile%%.*}
#CMD mongoimport --host mongodb --username loterias_admin --password loterias_admin_1234 --authenticationDatabase=admin --db probabilidade-loteria --collection DiaDeSorte --type json --file /diadesorte.json --jsonArray
#CMD ["mongoimport --host mongodb --username loterias_admin --password loterias_admin_1234 --authenticationDatabase=admin --db probabilidade-loteria --collection DiaDeSorte --type json --file /diadesorte.json --jsonArray", "mongoimport --host mongodb --username loterias_admin --password loterias_admin_1234 --authenticationDatabase=admin --db probabilidade-loteria --collection Federal --type json --file /federal.json --jsonArray", "mongoimport --host mongodb --username loterias_admin --password loterias_admin_1234 --authenticationDatabase=admin --db probabilidade-loteria --collection LotoFacil --type json --file /lotofacil.json --jsonArray","mongoimport --host mongodb --username loterias_admin --password loterias_admin_1234 --authenticationDatabase=admin --db probabilidade-loteria --collection LotoMania --type json --file /lotomania.json --jsonArray",m"mongoimport --host mongodb --username loterias_admin --password loterias_admin_1234 --authenticationDatabase=admin --db probabilidade-loteria --collection MaisMilionaria --type json --file /maismilionaria.json --jsonArray","mongoimport --host mongodb --username loterias_admin --password loterias_admin_1234 --authenticationDatabase=admin --db probabilidade-loteria --collection MegaSena --type json --file /megasena.json --jsonArray","mongoimport --host mongodb --username loterias_admin --password loterias_admin_1234 --authenticationDatabase=admin --db probabilidade-loteria --collection Quina --type json --file /quina.json --jsonArray","mongoimport --host mongodb --username loterias_admin --password loterias_admin_1234 --authenticationDatabase=admin --db probabilidade-loteria --collection SuperSete --type json --file /supersete.json --jsonArray","mongoimport --host mongodb --username loterias_admin --password loterias_admin_1234 --authenticationDatabase=admin --db probabilidade-loteria --collection TimeMania --type json --file /timemania.json --jsonArray"]

#FROM mongo

#COPY init.json /init.json
#CMD mongoimport --host mongodb --username loterias_admin --password loterias_admin_1234 --authenticationDatabase=admin --db probabilidade-loteria --collection MyDummyCollection --type json --file /init.json --jsonArray
