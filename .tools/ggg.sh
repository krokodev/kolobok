date > time.txt

echo.
echo [Add]
git add --all

echo.
echo [Commit]
git commit -a -m "$1 [Just refresh repository]"

echo.
echo [Push]
git push
