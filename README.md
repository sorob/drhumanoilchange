# Dr. Human Oil Change

An archival copy of the website and web application of **Dr. Albert William Aguirre**, kept so the work can still be read.

[Find a Grave memorial 163344172](https://www.findagrave.com/memorial/163344172/albert_william-aguirre) records him as Dr. Albert William Aguirre, born January 10, 1944, in Fresno, Fresno County, California, and died in November 2013 in Redding, Shasta County, California, at the age of 69. The burial place is listed as unknown. The memorial names his parents, Joseph L. Aguirre (1915–2003) and Beatrice C. Aguirre (1925–2002), and cites a California marriage index entry for his marriage to Margaret A. Coleman on August 12, 1964, in Fresno. Lester Letson added the memorial on May 26, 2016.

His obituary was published by the *Fresno Bee* on January 12, 2014:

[Albert Aguirre — Legacy.com](https://www.legacy.com/us/obituaries/fresnobee/name/albert-aguirre-obituary?id=9793545)

The notice that remains on that page is short. It says, “We will miss you. Your Family and Friends.”

This repository is the server copy of [drhumanoilchange.com](http://www.drhumanoilchange.com), also called Human Oil Change. The files date from December 2005 through October 29, 2013, the month before the death recorded on his memorial. It holds the teaching pages, the compiled site in `bin/`, and a C# reading copy of that program in `source/`.

## Who he was, in his own pages

On the site he signed the work **Al Aguirre, Ph., NMD, PhD**. The letterhead in the teaching pages places the work under NaturChem Health Systems, with a California branch in Redding, an Oregon branch in Portland, and Audrey’s Health Retreat in San Blas, Nayarit. The same pages point to HumanOilChange.com and NaturChem.com, and to Doctor’s Health Assurance Plan.

He described a life spent on nutritional medicine and biochemical laboratory follow-up, and a practice he moved onto the internet so the method could be taught from a computer rather than carried only in one office. The essays under `LabCalc/HTMLS/` and `LabCalc/BasicDiet.htm` are that teaching, in his wording.

[Shangrila Bio Spa](http://www.shangrilabiospa.com/doctors-health-assurance/) still presents that program as Doctor’s Health Assurance. The page is introduced by Genita M. Mason, H.H.P., N.C., M.H., medical director of The BioSanctuary Green Body & Mind Healing Center. It says a person becomes eligible after the Bio-CHEM Detox Program or a 28-day residency at the BioSanctuary, and that biochemistry is checked every eight months: a requisition goes to a local lab, then the results are interpreted and the targeted nutritional therapy is revised. Current patients are sent to log in at [www.drhumanoilchange.com](http://www.drhumanoilchange.com/) for test evaluations, program updates, and healthcare recommendations. The panel list, the notes drawn from John B. Miale’s *Laboratory Medicine Hematology*, and the Vesta F. testimonial on that page are the same teaching already in `LabCalc/HTMLS/pr.htm`. The page carries a 2023 copyright, so this is a later home for the program this archive preserves.

His LinkedIn profile, [Dr. Al Aguirre](https://www.linkedin.com/in/dr-al-aguirre-08672650), lists him as Medical Director in Redding, California. He wrote that he had been studying and practicing natural medicine for over fifty years, specializing in “Nutritional Biochemical Analysis,” and pointed readers to an “Interactive Computer Health Program.” He gave two addresses for that work: [www.BloodBalance.com](http://www.BloodBalance.com) and DrHumanOilChange.com. He also described a therapy he named GH6x, a buffering system he called six times stronger than GH3 and ten times more effective, made with natural therapeutic agents. That description is his own.

The Education section lists the University of Wyoming, 1968–1971, a Bachelor of Applied Science in Microbiology & Pharmacy, marked Graduate School. He wrote that the degrees were earned with honor. He listed himself as president of the Rho Chi Honor Society and entertainment director for Phi Delta Chi. On the same entry he added a doctorate in natural medicine from the NCNM school, a doctorate in clinical psychology from Brighton University, and four years of teaching at the National College of Naturopathic Medicine. The public text ends in the middle of that teaching note.

Under Skills he listed U.S. military training as a medic, pharmacy specialist, and medical specialist in compounding, and work as a food scientist and head of research and development.

## What is in this repository

| Path | What it is |
| --- | --- |
| `LabCalc/HTMLS/`, `LabCalc/BasicDiet.htm` | His teaching essays, as HTML |
| `Web.sitemap` | The menu of the running site |
| `bin/` | The precompiled ASP.NET 4 site, including `App_Code.dll` and one `App_Web_*.dll` per page |
| `source/` | Those application assemblies, decompiled so the logic can be read |
| `Files/` | Reference spreadsheets for tests, costs, and book references |
| `data/drhuman_no_patient.json` | The advice rules, reference ranges, WAT words, packages, and blog articles from the SQL backup |
| `Web.config` | The IIS configuration, with passwords replaced by `REDACTED` |

The site expected Internet Information Services, SQL Server, ASP.NET membership, Crystal Reports, and PayPal controls. The HTML essays open in a browser. Individual accounts and lab results are not in this archive. The rules those results were compared against are in `data/drhuman_no_patient.json`.

`bin/` also contains the libraries the site was deployed with: the Ajax Control Toolkit, iText, Crystal Reports components, PayPal controls, BouncyCastle, FreeTextBox, ConwayControls, Sahil.WebControls, and Validators. Those remain the binaries he shipped. `source/` is only the application.

## The recovered source

The deployed code was VB.NET. `source/` is an ILSpy reconstruction of that IL, so `My.MyProject` and `Microsoft.VisualBasic.CompilerServices` are still in the files, and the files themselves are C#. This is a reading copy of the published site, not the original project.

Inside each `source/App_Web_*` folder:

- The class named for the page (`LabCalc_ResultIn.cs`, `Admin_medman.cs`, `_Default.cs`) is the code-behind.
- `ASP/` is the control tree the compiler generated from the markup. The `.aspx` files at the root of the site are precompilation markers, so this folder is where the page layout survives.
- `My/` is the Visual Basic runtime helper the decompiler emitted.

`source/App_Code` is the shared program. The typed datasets and their table adapters are the database surface: `Labstuff` (results, treatments, packages, ratios, book references), `WAT`, `orders` (funds and deposits), `userinfo`, `textref`, `addtest`, `tempdata`, `blogupdate`, and `storeprociduresds`. `Utilities` resizes images and strips HTML. `Service` is an empty WCF stub.

### Pages worth opening first

| Area | Code-behind |
| --- | --- |
| Home and master page | `source/App_Web_default.aspx.cdcab7d2/_Default.cs`, `source/App_Web_master1.master.cdcab7d2/master1.cs` |
| About, contact, articles, FAQ | `ABOUTPG.cs`, `Contact.cs`, `Articles.cs`, `FAQ.cs`, `FAQReader.cs` in the matching `App_Web_*` folders |
| Account | `Login.cs`, `Regidter.cs`, `Activate.cs`, `AddUserInfo.cs`, `ChangePass.cs`, `recovery.cs` |
| Online lab | `LabCalc_Default.cs`, `LabCalc_ResultIn.cs`, `LabCalc_ResultView.cs`, `LabCalc_Edit_ResultEdit.cs`, `LabCalc_history.cs`, `LabCalc_compare.cs`, `LabCalc_bar.cs`, `LabCalc_ONEBYONE.cs` |
| WAT stress test | `WAT_Default.cs`, `WAT_Test.cs`, `WAT_score.cs`, `WAT_aval.cs` |
| P-6 Psych | `p6psych.cs`, `P6Psych_Default.cs`, `P6Psych_Default2.cs`, `P6Psych_P6s.cs` |
| Health assurance plans | `Services_Assurance.cs`, `Services_Family.cs`, `Services_Plan.cs`, `Services_Planframe.cs`, `Services_2P.cs`, `Services_2PRx.cs`, `Services_prices.cs` |
| Money | `Financial_AddFunds.cs`, `Financial_Bank.cs`, `SalesConfirmation.cs`, `buy.cs` |
| Reports | `GetReport.cs` |
| Website manager | `WebManager.cs`, `Admin_usermanager.cs`, `Admin_RefEdit.cs`, `Admin_medman.cs`, `Admin_ParserEdit.cs`, `Admin_deposits.cs`, `Admin_booklist.cs`, `Admin_packageEditor.cs`, `Admin_deleteUsers.cs`, `Admin_ratioEditor.cs`, `Admin_watList.cs`, `Admin_WatView.cs` |

The lab pages follow the sequence he wrote in `LabCalc/HTMLS/pr.htm`: history, complaints, prior tests, blood type and diet, stress tests, blood chemistry, a supplement and food plan, exercise, and a recheck. The admin editors are where reference ranges, treatments, the parser, book references, test packages, and ratio logic were maintained.

## The advice data

`data/drhuman_no_patient.json` is the reference half of a full backup of the `drhuman` database. SQL Server 2008 R2 Express on `TELEVIZIOON\SQLEXPRESS` wrote that backup on March 6, 2014. The file is one JSON object. `tables` holds the rows. `omitted` names every table that was left out, with the row count and the reason.

The advice itself is `tables.Rx`, 589 rows. A row is a test abbreviation (`Abrev`), whether the result is `High` or `Low`, a product, a dose, a company (`Co`), a body part, a gender, and `minScale2Show`, the distance from the reference range required before that line is shown. `CPRx` does the same for a calcium/phosphorus ratio between `minCP` and `maxCP`. `TPR` does it for a total-protein value between `min` and `max`.

The ranges those rules use are in `TestRef` (doctor ranges and medical ranges, by test and sex) and `MaleRF`. `ratioRef` names which two tests form a ratio. `grp` groups tests. `package` and `packagedata` are the panels and the tests inside them. `testbookref` is the book, author, page, and note for a test. `mainWord` and `choiceWord` are the WAT word list and the score for each answer. `ScRanges` maps a score to a report band. `blog` is the 31 articles, with the account name that posted them removed. Two of his own published addresses, `dralaguirre2@aol.com` and `dralaguirre@netscape.net`, remain inside that article text.

These tables were left out because they identify people or store their results: `UserInfo` (227 rows, including names, addresses, phone numbers, birth dates, and Social Security numbers), `aspnet_Membership` and `aspnet_Users` (222 accounts, emails, and password hashes), `ResultRef` (16,470 lab results), `Tests`, `txtimp`, `complaints`, `testInstance`, `testWordInstance`, `gotadvice`, `Funds`, `deposits`, `download`, and the PayPal table `ahn`. That full export stays off this repository.

## What was left out of the public copy

Database and mail passwords in `Web.config` were replaced with `REDACTED`. The old server names and database names remain, so the shape of the system is visible. The decompiled pages call those connection-string names. They do not contain the passwords.

`App_Data/drhuman_Log.ldf`, a SQL Server log from the live application, stays on the original disk and is listed in `.gitignore`. A scan of that log found no readable personal records. A health-application database log stays out of a public archive.

`Files/CRRedist2008_x86.msi`, the Crystal Reports 2008 redistributable installer, was left out. It is a vendor package.

## Reading the archive

Start with `LabCalc/BasicDiet.htm` and the numbered essays in `LabCalc/HTMLS/` for his voice. Use `Web.sitemap` for the menu. Use the table above when you want the program behind a screen. `source/App_Code/Labstuff.cs` is the data model of the lab. `data/drhuman_no_patient.json` is the advice those screens looked up, beginning with `tables.Rx`.
