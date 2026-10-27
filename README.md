# Dr. Human Oil Change

An archival copy of the website and web application of **Dr. Albert William Aguirre**, kept so the work can still be read.

[Find a Grave memorial 163344172](https://www.findagrave.com/memorial/163344172/albert_william-aguirre) records him as Dr. Albert William Aguirre, born January 10, 1944, in Fresno, Fresno County, California, and died in November 2013 in Redding, Shasta County, California, at the age of 69. The burial place is listed as unknown. The memorial names his parents, Joseph L. Aguirre (1915–2003) and Beatrice C. Aguirre (1925–2002), and cites a California marriage index entry for his marriage to Margaret A. Coleman on August 12, 1964, in Fresno. Lester Letson added the memorial on May 26, 2016.

His obituary was published by the *Fresno Bee* on January 12, 2014:

[Albert Aguirre — Legacy.com](https://www.legacy.com/us/obituaries/fresnobee/name/albert-aguirre-obituary?id=9793545)

The notice that remains on that page is short. It says, “We will miss you. Your Family and Friends.”

This repository is the server copy of [drhumanoilchange.com](http://www.drhumanoilchange.com), also called Human Oil Change. The files date from December 2005 through October 29, 2013. The newest page is from the month before the death recorded on his memorial. It is the site as it stood at the end of his life: the teaching pages, the lab program, and the tools around them.

## Who he was, in his own pages

On the site he signed the work **Al Aguirre, Ph., NMD, PhD**. The letterhead in the teaching pages places the work under NaturChem Health Systems, with a California branch in Redding, an Oregon branch in Portland, and Audrey’s Health Retreat in San Blas, Nayarit. The same pages point to HumanOilChange.com and NaturChem.com, and to Doctor’s Health Assurance Plan.

He described a life spent on nutritional medicine and biochemical laboratory follow-up, and a practice he moved onto the internet so the method could be taught from a computer rather than carried only in one office. The essays under `LabCalc/HTMLS/` and `LabCalc/BasicDiet.htm` are that teaching, in his wording. They are preserved as a record of how he explained the work.

## What he wrote on his public profile

His LinkedIn profile, [Dr. Al Aguirre](https://www.linkedin.com/in/dr-al-aguirre-08672650), lists him as Medical Director in Redding, California. In the About section he wrote that he had been studying and practicing natural medicine for over fifty years, specializing in “Nutritional Biochemical Analysis,” and pointed readers to the results of an “Interactive Computer Health Program.” He gave two addresses for that work: [www.BloodBalance.com](http://www.BloodBalance.com) and DrHumanOilChange.com, and said to use Contact Us. He also described a therapy he named GH6x, a buffering system he called six times stronger than GH3 and ten times more effective, made with natural therapeutic agents. That description is his own.

The Education section lists the University of Wyoming, 1968–1971, a Bachelor of Applied Science in Microbiology & Pharmacy, marked Graduate School. He wrote that the degrees were earned with honor. He listed himself as president of the Rho Chi Honor Society and entertainment director for Phi Delta Chi. On the same entry he added a doctorate in natural medicine from the NCNM school, a doctorate in clinical psychology from Brighton University, and four years of teaching at the National College of Naturopathic Medicine. The public text ends in the middle of that teaching note.

Under Skills he listed U.S. military training as a medic, pharmacy specialist, and medical specialist in compounding, and work as a food scientist and head of research and development.

## What the application did

This folder is the deployed ASP.NET 4 site, precompiled for Internet Information Services. Most `.aspx` files are precompilation markers. The compiled application is in `bin/`, including `App_Code.dll` and one `App_Web_*.dll` for each page. Those application assemblies are also recovered as C# under `source/`.

The deployed code was VB.NET. `source/` is an ILSpy reconstruction of that IL, so names, `My.MyProject`, and `Microsoft.VisualBasic.CompilerServices` calls show the original language, while the files themselves are C#. `source/App_Code` holds the shared types: lab datasets, WAT, orders, user info, the service, and `Utilities`. Each `source/App_Web_*` folder is one precompiled page, with the control tree the compiler generated from the markup.

The other files in `bin/` are the libraries the site was deployed with: the Ajax Control Toolkit, iText, Crystal Reports components, PayPal controls, BouncyCastle, FreeTextBox, ConwayControls, Sahil.WebControls, and Validators. Those stay as the binaries he shipped.

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
