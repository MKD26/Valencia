Die shader Datei in

GitHub\Valencia\Robotic world\Library\PlayerDataCache\OSXUniversal\Data\sharedassets2.assets.resS
C:\Users\julia\Documents\GitHub\Valencia\Robotic world\Robotic-worl-game-V1.app\Contents\Resources\Data\sharedassets2.assets.resS

überschreitet das git-mögliche Maximum von 100 MB pro Datei. Nach clonen des Repositories diese von Hand
in den Ordner kopieren. Ich habe die Datei in das .gitignore file eingetragen, sie stört damit nicht mehr
bei der weiteren Arbeit.

Vom Namen her kann es auch sein, dass die Datei (und alle anderen .resS) zur Laufzeit immer wieder neu
erstellt werden. Dann könnt ihr im .gitignore file auch alle ausschliesen. Dazu einfach *.resS unter die Liste 
hängen.