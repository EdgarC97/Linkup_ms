# READ EVERY TIME YOU WILL WORK WITH THE REPOSITORY
## Instructions for correct workflow

## Ramas y Flujo de Trabajo (Git Flow)
main: Rama principal que contiene el código en producción o listo para producción.
develop: Rama para integrar nuevas características y desarrollar.
feature/feature-name: Ramas para trabajar en nuevas características. Creadas a partir de develop.
hotfix/hotfix-name: Ramas para arreglar errores críticos en producción. Creadas a partir de main.
release/release-name: Ramas para preparar una nueva versión estable. Creadas a partir de develop.

## Inicialización del Repositorio:
Brayan o Nicolas clonan el repositorio: 
git clone https://github.com/EdgarC97/Linkup_ms.git
cd Linkup_ms

## Trabajo en las features 

### Crea una rama de features a partir de develop:
git checkout develop
git pull origin develop
git checkout -b feature/nueva-feature
### Trabaja en la feature y haz commits regularmente:
git add .
git commit -m "Añadida nueva clase"

## Fusion de features
### Cuando la característica esté completa, haz push y crea un Pull Request (PR) en GitHub:
git push origin feature/nueva-feature
Revisa el código y fusiona el PR en develop OJO siempre a develop

--FINALIZA PROCESO DE CREACION DE RAMAS, PUSH Y PULL REQUESTS--

## Proceso para preparar la version
### Crea una rama de release a partir de develop
git checkout develop
git pull origin develop
git checkout -b release/v1.0

Realiza pruebas y correcciones en esta rama.
### Fusiónala en main y develop:
git checkout main
git merge release/v1.0
git checkout develop
git merge release/v1.0

## Corrección de Errores Críticos:
### Crea una rama de hotfix a partir de main
git checkout main
git pull origin main
git checkout -b hotfix/fix-critico
### Realiza la corrección y haz commit:
git add .
git commit -m "Corrección crítica"
git push origin hotfix/fix-critico
### Fusiona la rama hotfix en main y develop:
git checkout main
git merge hotfix/fix-critico
git checkout develop
git merge hotfix/fix-critico
