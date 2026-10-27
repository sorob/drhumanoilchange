# Dr. Human Oil Change

An archival copy of the website and web application of **Albert “Al” Aguirre**, kept so the work can still be read.

His obituary was published by the *Fresno Bee* on January 12, 2014:

[Albert Aguirre — Legacy.com](https://www.legacy.com/us/obituaries/fresnobee/name/albert-aguirre-obituary?id=9793545)

The notice that remains on that page is short. It says, “We will miss you. Your Family and Friends.”

This repository is the server copy of [drhumanoilchange.com](http://www.drhumanoilchange.com), also called Human Oil Change. The files date from December 2005 through October 29, 2013, a few months before that notice. It is the site as it stood near the end of his life: the teaching pages, the lab program, and the tools around them.

## Who he was, in his own pages

The site names him **Al Aguirre, Ph., NMD, PhD**. The letterhead in the teaching pages places the work under NaturChem Health Systems, with a California branch in Redding, an Oregon branch in Portland, and Audrey’s Health Retreat in San Blas, Nayarit. The same pages point to HumanOilChange.com and NaturChem.com, and to Doctor’s Health Assurance Plan.

He described a life spent on nutritional medicine and biochemical laboratory follow-up, and a practice he moved onto the internet so the method could be taught from a computer rather than carried only in one office. The essays under `LabCalc/HTMLS/` and `LabCalc/BasicDiet.htm` are that teaching, in his wording. They are preserved as a record of how he explained the work.

## What the application did

This folder is the deployed ASP.NET 4 site, precompiled for Internet Information Services. Most `.aspx` files are precompilation markers. The application logic is in the assemblies under `bin/`, especially `App_Code.dll`. The original project source is not in this copy.

`Web.sitemap` is the map of the running site:

- Home, products, articles, FAQ, about, and contact
- Health assurance plans, including family plans
- WAT testing
- P-6 Psych stress tester
- Online lab (`LabCalc`): entering results, history, and comparison
- Administration: lab users, reference ranges, treatments, the parser database, deposits, book references, test packages, and ratio logic
- Adding funds and viewing submitted deposits

The lab pages walk a client through history, complaints, prior tests, blood type and diet, stress tests, blood chemistry, a supplement and food plan, exercise, and a recheck. That sequence is written out in `LabCalc/HTMLS/pr.htm`.

The site expected SQL Server, ASP.NET membership, Crystal Reports, and PayPal controls. Opening these files in a browser will show the HTML essays. It will not recreate the logged-in lab, because the database of accounts and results is not part of this archive.

`bin/` also contains libraries the site was deployed with, including the Ajax Control Toolkit, iText, and Crystal Reports components. Those libraries remain the work of their publishers.

## What was left out of the public copy

Database and mail passwords in `Web.config` were replaced with `REDACTED`. The old server names and database names are still there, so the shape of the system is visible.

`App_Data/drhuman_Log.ldf`, a SQL Server log from the live application, stays on the original disk and is listed in `.gitignore`. A scan of that log found no readable personal records. A health-application database log still stays out of a public archive.

`Files/CRRedist2008_x86.msi`, the Crystal Reports 2008 redistributable installer, was also left out. It is a vendor package, not a page he wrote.

## Reading the archive

Start with `LabCalc/BasicDiet.htm` and the numbered essays in `LabCalc/HTMLS/`. Use `Web.sitemap` when you want the list of application screens. The precompiled pages record where each screen lived; the prose of the practice is in the HTML.
