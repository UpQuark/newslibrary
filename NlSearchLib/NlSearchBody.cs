﻿namespace NewsLibrarySearch
{
    /// <summary>
    /// Builder for NewsLibrary request body
    /// </summary>
    public class NlSearchBody
    {
        public string Body
        {
            get { return _bodyHeader + _bodyMiddle + _bodyFooter; }
        }

        private readonly string _bodyHeader;
        private readonly string _bodyMiddle;
        private readonly string _bodyFooter;

        private readonly string _date;
        private readonly string _searchTerm;
        private readonly string _fieldTarget;

        private string FieldBase = "&p_field_base-0=";
        private string DateBase = "&p_text_YMD_date-0=";

        //Single search, single _date and single target
        public NlSearchBody(string date, string searchTerm, string fieldTarget)
        {
            _date = date;
            if (date == "")
                DateBase = "";

            _searchTerm = searchTerm;
            _fieldTarget = fieldTarget;
            //_fieldTarget = "";
            _bodyHeader = @"s_siteloc=NL2&p_queryname=4000&p_action=search&p_product=NewsLibrary&p_theme=newslibrary2&s_search_type=customized&d_sources=location&d_place=United+States&p_nbid=&p_field_psudo-sort-0=psudo-sort&f_multi=&p_multi=";
            _bodyMiddle = bodyMiddleDefault();
            _bodyFooter = "&p_widesearch=smart&p_sort=YMD_date%3AD&p_maxdocs=200&p_perpage=10&p_text_base-0=" + _searchTerm + FieldBase + fieldTarget + "&p_bool_base-1=AND&p_text_base-1=&p_field_base-1=Section&p_bool_base-2=AND&p_text_base-2=" + "&p_field_base-2=" + DateBase + _date + "&p_field_YMD_date-0=YMD_date&p_params_YMD_date-0=date%3AB%2CE&p_field_YMD_date-3=YMD_date&p_params_YMD_date-3=date%3AB%2CE&Search.x=18&Search.y=18";
        }
        
        //Just exists to hide the horribly long default val
        private string bodyMiddleDefault()
        {
            return "ZTFQ%7CZIQO%7CATWA%7CARWA%7CBIR1%7CBIWA%7CBRB5%7CWBBJ%7CBEHB%7CWBHBB%7CBLCH%7CNCB1%7CCKR1%7CCWPR%7CWCVR%7CC2KS%7CZIQR%7CC7KWS%7CCKRS%7CCKOB%7CCWCB%7CCBHC%7CVC%7CCRBE%7CEWHB%7CDNWA%7CEBRB%7CADWB%7CDPTW%7CWECH%7CFWMZ%7CFFFF%7CF1K8%7CZIQM%7CZIQN%7CISEZ%7CIWLZ%7CIRWA%7CJSJF%7CKRKK%7CKCJB%7CWKCN%7CKCWA%7CWKNN%7CBMSB%7CWKSBB%7CLCMC%7CLEWA%7CMVRZ%7CMGWA%7CMIRZ%7CWN5K%7CZIQP%7CTNTB%7CNTBT1%7CNCNO%7CNKHZ%7CNNWA%7CNNW9%7COVGT%7COLPB%7COBOO%7CPPCP%7CPDNP%7CZMDG%7CPGBG%7CPOIZ%7CZMFE%7CQCHQ%7CRRWA%7CRRR7%7CSRS3%7CSESS%7CIG%7CSE%7CSTBS%7CSGWA%7CSGHB%7CSVRZ%7CSPBP%7CSWRC%7CSEWA%7CSR%7CSECB%7CTEWA%7CTCHB%7CTCHBK%7CTRWA%7CVBJB%7CVMIB%7CVLNN%7CZMHI%7CWBJ9%7CWWDB%7CWCWA%7CWNTC%7CZMGS%7CVMWB%7CYEWA%7CYHRB%7CADHA%7CAOOB%7CADTA%7CBAKH%7CBEOR%7CMTEB%7CBULB%7CCTSB%7CCCS6%7CLCAA%7CCGTC%7CCGTBC%7CCURT%7CPJCB%7CASDB%7COSDB%7CDLCB%7CEPOP%7CEORB%7CEEOR%7CKFNB%7CHNSS%7CHRNH%7CKKOB%7CLEOR%7CLRMM%7CZMEK%7CMEM4%7CKGW8%7COBLG%7COR%7COBPP%7COWEAP%7CPIF1%7CPEOR%7CRSOR%7CERGB%7COSBJ%7CSNOR%7CSMS5%7CWCCB%7CWOJM%7CCBWB%7CZIAQ%7CZIAK%7CACOB%7CAVE%7CADPB%7CATSB%7CZMGI%7CALRB%7CACEN%7CAEA8%7CAVPB%7CAANM%7CAPDB%7CAWCB%7CLCAB%7CCFAB%7CAJCA%7CACPB%7CBCAB%7CBAKBL%7CBCWEB%7CBECA%7CGBUB%7CBCC9%7CBCHB%7CBAVB%7CBERB%7CBVHB%7CBHWB%7CBBGB%7CBWDB%7CBLB2%7CBWCB%7CBUGB%7CBLDN%7CBSCB%7CGCCB%7CCANW%7CCPB8%7CCWC8%7CCCA2%7CCACA%7CCBTB%7CCRS9%7CCPBB%7CCYNB%7CZIAP%7CZIAM%7CCEBB%7CCSCB%7CCERB%7CCHIE%7CCNOB%7CCHLB%7CCVEC%7CCLKB%7CZMCM%7CCRCB%7CCRCA%7CCCA6%7CCONB%7CZMGY%7CCNCA%7CCMBB%7CCC%7CZMGZ%7CZISE%7CCCOB%7CCUPB%7CC55L%7CSDAS%7CBRZB%7CZUAQ%7CDCB9%7CWDDB%7CDFN9U%7CDIRB%7CPADB%7CLA%7CDPC8%7CSFDB%7CZMGB%7CHDRB%7CDTIUF%7CDTCC%7CZUAT%7CDVTB%7CDVEB%7CDLNB%7CZMCS%7CDVSB%7CDTTT%7CZMDH%7CEBDB%7CEBE1%7CEGPB%7CEVAL%7CERDB%7CECHB%7CEDHT%7CEMSS%7CELTB%7CEVGG%7CZMFU%7CEOTB%7CEECA%7CFTF9%7CFBAB%7CZIAJ%7CF2KWO%7CF5KS%7CFK4S%7CFBLB%7CFB%7CFBB1%7CFEFF%7CGCEG%7CGIWB%7CNPG2%7CGHGB%7CGZ%7CUGS1%7CHMBR%7CHNSB%7CZMDS%7CHDSB%7CHBBB%7CHBFV%7CITCI%7CIMPB%7CIVP%7CZIAN%7CZIRK%7CIENN%7CVDBB%7CIRBB%7CLEWB%7CKVSB%7CKCRB%7CLAOB%7CLWTB%7CLALB%7CLLCB%7CLCWB%7CLCVS%7CLGFB%7CLOPC%7CRCPB%7CLVL9%7CDACL%7CLBCP%7CLCRB%7CLNCB%7CLACB%7CLNML%7CLODB%7CLPRB%7CLBEL%7CLB%7CLNCA%7CLDTB%7CLAEL%7CLOLB%7CSLAB%7CLBEB%7CLGDB%7CLGWB%7CMTCB%7CMUBB%7CMTMM%7CMTBB%7CMIJB%7CMNGM%7CMBNB%7CMSSB%7CMSSBM%7CDMDT%7CMPPB%7CMS%7CMBBM%7CMEM8%7CMWCB%7CMC%7CMCWS%7CMEM3%7CPCMB%7CMPAB%7CMREB%7CMNLB%7CMSHM%7CMLAB%7CCPMD%7CNVR1%7CZIAO%7CZIAL%7CZIAR%7CCNDS%7CNNSB%7CNCYT%7CNSPP%7CODLB%7COECA%7COKTB%7COPY1%7COVNB%7COC%7COCRBB%7CORCHI%7CZMHL%7COMRB%7COWLB%7CPPSB%7CLPCB%7CPFTB%7CCPSE%7CPVPB%7CPPOB%7CPLNB%7CPICB%7CPJN1%7CPSWB%7CPSS2%7CPHRB%7CPNTB%7CPPP6%7CPVRB%7CSA%7CRS%7CPTRR%7CPUCMM%7CPYCM%7CZMFO%7CRBDB%7CRSLB%7CRRSBR%7CRDFB%7CRCDB%7CRWTB%7CCVRB%7CRRCB%7CRBNB%7CRCRB%7CRECA%7CROSB%7CSB%7CSBBS1%7CSES7%7CSDES%7CSDUN%7CSDUT%7CSDUTS%7CSFVB%7CSFCB%7CCSFE%7CSFFS%7CSGVN%7CSGVB%7CSJES%7CSJ%7CSMCB%7CSDJB%7CSMAB%7CSAES%7CSBES%7CZMCD%7CSCS2V%7CSCS9%7CSMTB%7CSMDB%7CSMSB%7CSRNB%7CSCEB%7CSMWB%7COSSB%7CSIGB%7CSIVB%7CYCSB%7CSITB%7CSSSSR%7CSSDS%7CSLGB%7CSQOB%7CSHS6%7CSTDUV%7CZMGM%7CSES4%7CSBCB%7CSVSB%7CZMAI%7CTOAB%7CTPRB%7CVTHB%7CETSB%7CTVHB%7CTVTP%7CSO%7CTBSB%7CTLJB%7CTCTB%7CUDJB%7CUDS1%7CUGLB%7CVASB%7CVJSS%7CVCSB%7CVCSBB%7CVEEVF%7CCVEEV%7CCVEEV1%7CWCC7%7CCHWB%7CWTDB%7CWDNB%7CWNCB%7CWGRB%7CZMDV%7CAS%7CADNBA%7CAEAK%7CAPAA%7CASAK%7CAWJA%7CBBTA%7CCTAK%7CADSS%7CDDAK%7CFDNB%7CJUEB%7CKDMB%7CKTVB%7CMSVF%7CKTUU%7CNNAK%7CNLAA%7CAPCB%7CSPLS%7CSSFF%7CTDBA%7CZIDE%7CBIWB%7CZIDF%7CZIDC%7CGILI%7CHHTH%7CHBHI%7CHRHI%7CHNAB%7CHEHI%7CHMHI%7CHSAXH%7CHSHI%7CHSBB%7CHWHH%7CKLOH%7CKKOH%7CKHH1%7CBKKA%7CKKH1%7CMMKK%7CMDKB%7CZIDG%7CNHNW%7CWNHB%7CHBH9%7CWHTK%7CBDTBB%7CBEWV%7CCDMB%7CCEWV%7CCIZB%7CCECK%7CCVLB%7CDAMM%7CZMEQ%7CFTOO%7CGBTB%7CHHDB%7CIHRB%7CJHRB%7CVLBB%7CMDNT%7CMHWV%7CWVMB%7CPEWV%7CWVRB%7CPTWV%7CRHBB%7CJSNR%7CTWVB%7CTWLS%7CWEWV%7CWDYB%7CWVEC%7CAGZB%7CANEP%7CACHB%7CACVB%7CAEVA%7CASGM%7CLCVB%7CATL9%7CBBVA%7CBCMB2%7CBHCR%7CBHCB%7CBUMWF%7CBLVBB%7CBCVB%7CCARB%7CCCC2%7CCDC5%7CWTKR%7CWTVR%7CWDBJ%7CCVVB%7CVCBJ%7CCHVI%7CCEVA%7CCRVR%7CCTVCR%7CCGMUF%7CCULP%7CCSEB%7CVNRB%7CDPRO%7CDPBC%7CDVRB%7CDIVI%7CVBOB%7CFCVB%7CFSCB%7CFPVA2%7CFFSB%7CGGGB%7CCVGG%7CGFCB%7CGFMO%7CGCRB%7CHSTHH%7CHCVB%7CHCUV%7CVJPB%7CLHCB%7CLTVA%7CLBVA%7CMCVA%7CMCEM%7CMCVB%7CMVLB%7CMLAA%7CMVGB%7CN10W%7CNCTA%7CNAVA%7CNMES%7CNMBB%7CNVIR%7CNGLL%7CNEVA%7CNFJB%7CNAGB%7CNVDB%7CNVPR%7CVOCR%7CPNCB%7CPHWH%7CPTGG%7CPIXB%7CRCVB%7CRNPB2%7CREVA%7CRTDB%7CRTDBB%7CRER7%7CRO%7CRTWB%7CRLUF%7CVSJB%7CSVBB%7CSVHB%7CSCNM2%7CSCVB%7CVSCS1%7CTRVR%7CVVBB%7CVOCB%7CVBEV%7CVBMB%7CVGWW%7CVALB%7CNK%7CRWSB%7CVWCN2%7CVWSB%7CWEVA%7CA9WWC%7CANRB%7CAPXB%7CBHN1%7CBLA1%7CBDJB%7CBOLB%7CBRNC%7CBBAA%7CBBSBB%7CCENCD%7CCATB%7CCRYN%7CC9WG%7CCECH%7CCJNB%7CCO%7CCOBC%7CCHRB%7CCHE1%7CCDND%7CCLPB%7CRCTB%7CCTA9%7CCLCC%7CECDB%7CFCDB%7CDDHB%7CDHRR%7CZMEA%7CGVRB%7CDSTT%7CZMGO%7CDLNL%7CDTDT%7CDTPHK%7CDENC%7CEAWN%7CZMCZ%7CEJMM%7CFEF1%7CFENC%7CFV%7CFOBB%7CFW81%7CFTLL%7CZMED%7CFVIB%7CNGNB%7CGENC%7CGGNG%7CZMDL%7CDHSB%7CHICK%7CHPEB%7CHHN1%7CHSSB%7CITBN%7CJFPB%7CKCKK%7CLEXB%7CNCOB%7CEWN1%7CMDWN%7CMTCC%7CMTNC%7CMOTM%7CMTBBB%7CZMES%7CMANB%7CNGNN%7CN17W%7C36WC%7CGB%7CNRBG%7CRLOB%7CNEOBS%7CNOWER%7CNHNC%7CWNRB%7CNTOP%7CNCLB%7CONEB%7CPDCB%7CPPNB%7CPWH1%7CPLTB%7CSPNB%7CPBNC%7CPNLB%7CQCQUC%7CRENC%7CRGAB%7CRSCR%7CREIR%7CRBAB%7CRCJB%7CROBB%7CNCTB%7CSPNC%7CSSIB%7CSHRB%7CZMAY%7CSMFH%7CSHEB%7CSPR9%7CSLNC%7CSNAP%7CZMFQ%7CWSNB%7CSRLK%7CSKNB%7CZMGK%7CSHCB%7CTLTB%7CTRNR%7CTTT9%7CTDWB%7CTLG+%7CZMCH%7CTSVB%7CTRBB%7CTDBB%7CWLEC%7CWSFB%7CWDNC%7CWWNB%7CWTNC%7CWILB%7CNWSE%7CWJ%7CWSJBB%7CYRPB%7CBCNH%7CCBLB%7CDEWB%7CDPDE%7CETHN%7CGHLB%7CHCNH%7CJHDB%7CLSRB%7CMLPP%7CMTDE%7CMBDE%7CMCDE%7CNLPB%7CNPDE%7CR4FB%7CSCST%7CSCGG%7CSPDE%7CWEDE%7CAEAS%7CAHAMH%7CAWAF%7CABMB%7CMDAB%7CANEE%7CBEMD%7CBTGB%7CBSEB%7CBMMB%7CDBCC%7CSBTB%7CBMBB%7CFSBL%7CCGM9%7CAN%7CCCTW%7CCVTB%7CCWIG%7CCBLE%7CCYPB%7CCFMB%7CCTMD%7CCTH8%7CCTDE%7CCNTC%7CBDRB%7CCDSB%7CEEMB%7CEWCC%7CFSMS%7CZMDD%7CDMHH%7CHCTB%7CJEFB%7CBJTB%7CJHNL%7CKCNB%7CLLMB%7CMAMC%7CNCMB%7CNEBB%7CNBRP%7CNRMB%7COMTB%7CPAMB%7CPGSB%7CQUIN1%7CRHM6%7CCROB%7CSFM%7CESDB%7CBS%7CSSEB%7CDTRB%7CBMHB%7CTOWB%7CWEMB%7CASFB%7CWDBB%7CBABG%7CCSDB%7CCXBB%7CDCHU%7CEAU1%7CEPGB%7CGUV1%7CHLNB%7CHLWB%7CHGU1%7CITWB%7CZMGC%7CZMHP%7CZMGP%7CZCBM%7CWDEW%7CFMWB%7CWJWB%7CWT%7CAIKB%7CAIMB%7CAIMBB%7CBGZ1%7CSBGB1%7CBTB9%7CBHPB%7CCMNB%7CCPMB%7CCB7W%7CCW1W%7CSCSE%7CSCCB%7CCNRC%7CCAOB%7CCESC%7CMBIB%7CDJMB%7CWSDB%7CDCEB%7CEPEB%7CEADB%7CENQH%7CFMIT%7CGFLB%7CGTSC%7CGESC%7CGCSC%7CHTRS%7CHRIB%7CRHHB%7CSHJB%7CCHIB%7CIJG1%7CILP1%7CBEBB%7CWJRB%7CLAWY%7CLNSCB%7CMSME1%7CMESB%7CMORNN%7CMNBF%7CNW2C%7CNBOB%7CNPLL1%7CPPJB%7CPKSB%7CCPCB%7CPPPB%7CBJSB%7CSCLB%7CCS%7CSBSC%7CMB%7CSNBM%7CCTC5%7CTTOC%7COTDB%7CUDTB%7CWOHB2%7CA2WWA%7CA6WF%7CAEA5%7CAHAG%7CANGA%7CATRB%7CABHB%7CGAWB%7CAEGA%7CAJTB%7CAT%7CAGCB%7CACBA%7CAEA6%7CBCNW%7CBNGA%7CBRGRA%7CBSKK%7CBSMAM%7CZMGL%7CBCN2%7CBISS%7CAGBB%7CC3WC%7CZICZ%7CHTCC%7CGCLN%7CCTGA%7CCNFF%7CCNDB%7CCLSB%7CCAAB%7CSGPB%7CCSRB%7CCGCSM%7CCGPCD%7CCGEC%7CCDCC%7CDCGA%7CDTNC%7CNDKN%7CDCSD%7CDNGA%7CDWCB%7CECJS%7CENGG%7CEWAA%7CFCGA%7CGFCN%7CFNFZ%7CFCNB%7CFHGB%7CGADS%7CGDNG%7CGDPB%7CHDHB%7CHNFZ%7CAASI%7CJPAB%7CJCHB%7CJCNJ%7CKMGSM%7CKAGA%7CLGNB%7CGLOL%7CCL%7CCLEBB%7CLTGA%7CMEGA%7CMT%7CMTBM%7CMDJB%7CMTGA%7CMNGA%7CMOMB%7CN3WS%7CNNAA%7CTHGA%7CGNCM%7CNCZB%7CNSSN%7CPCSD%7CPNDZ%7CPCP5%7CARHB%7CRCZB%7CRNGA%7CGSSN%7CSEGA%7CSMNB%7CSAVB%7CSKGK%7CSAGA%7CSMPGR%7CSFNF%7CTAGA%7CTTGA%7CTTET%7CTGTT%7CGMTB%7CTGC1%7CTIPCF%7CURMB%7CVDLB%7CMWTB%7CWJHB%7CWPGP%7CGWCN%7CWPTN%7C8TFB%7CZIBT%7CZICL%7CA9WWO%7CZIBZ%7CZICR%7CZICO%7CAFLA%7CANFL%7CBONB%7CBLMT%7CBTMB%7CBBTK%7CBBVB%7CBBNA%7CBOCB%7CBTNB%7CBH%7CFBHBB%7CBOSB%7CBNBB%7CCBLL%7CZICD%7CZICK%7CZICM%7CZIBQ%7CZICQ%7CCKBB%7CCFFO%7CCMDB%7CCNCB%7CCFZB%7CFCCCB%7CCNC9%7CCNFN%7CCCN8%7CCGNC%7CCPFP%7CCLT9%7CFTCNA%7CCNUSS%7CCNSUF%7CFCBN%7CZIRP%7CLDCB%7CNJ%7CDSFB%7CZMCT%7CDLAB%7CDTFL%7CFEOB%7CEN%7CENHBB%7CECMT%7CESFB%7CFKKB%7CFNFF%7CFTUB%7CFTUBJ%7CFTUWJ%7CFLEF%7CFMLF%7CFWFM%7CFFTB%7CZICH%7CZICN%7CZICS%7CZICJ%7CZIBS%7CFNFL%7CFMEF%7CGCQT%7CGEGG%7CGSGB%7CGCDB%7CGBRB%7CHHCCY%7CHERN%7CHEFL%7CHILD%7CHNFL%7CIBII%7CZICE%7CIFAG%7CISPNA%7CJCFL%7CJEJ1%7CJNFL%7CKGK1%7CKWCB%7CKSK9%7CLPMB%7CFLPJ%7CLPLB%7CFLWN%7CLLFB%7CLBFL%7CLBOB%7CMIEB%7CMFPB%7CFMBN%7CMEFL%7CFMGN%7CMH%7CMHBB%7CMHFL%7CMUTT%7CNDNB%7CNDNBB%7CFWNEN%7CNSTN%7CNJUJ%7CZIBR%7CZICI%7CZICT%7CZICG%7CZICP%7CZMFG%7CSFNB%7CNMOB%7CNPFB%7CZMDF%7COSBB%7CONOO%7CFOLR%7COTFT%7COEFL%7COMNO%7COWKB%7CFOBO%7CPA%7CPBPB%7CPCOP%7CFPBN%7CFPCE%7CPPP4%7CPPFL%7CPTFL%7CPCO8%7CPCDB%7CPCTB%7CPGPC%7CTREB%7CRNDB%7CHT%7CFSOB%7CSNFN%7CSFTF%7CFSLB%7CSMCO%7CSMNS%7CSHOB%7CARSB%7CFSPE%7CFS%7CSCTBB%7CSBFB%7CSIBSS%7CSDFL%7CTEFL%7CTMFL%7CTBET%7CTBMNT%7CSPTB%7CSPTBS%7CSPTWS%7CTT%7CFTTB%7CZICF%7CTCBB%7CTCPBS%7CZICA%7CZICB%7CPOFO%7CVGSB%7CVB%7CVSNB%7CVUWFP%7CWNCC%7CZMFS%7CWPBEW%7CFWPN%7CDDBD%7CDDBBB%7CWVBSD%7CDDBW%7CWPSN%7CEND1%7CSJSB%7CVIDN%7CBEMT%7CBEB7%7CBZMB%7CBDCBB%7CCFVP%7CDILC%7CAEBB%7CGFEG%7CHHNH%7CMKUM%7CLCLAP%7CMIMT%7CMEMT%7CZMCI%7CNWMB%7CRMSB1%7CSHMT%7CWSNL%7CWNLL%7CWPW7%7CBEID%7CBCDBE%7CBFHB%7CCMID%7CCRAB%7CIDRB%7CIIFE%7CIPTB%7CIPTBB%7CISJB%7CISJBB%7CIDSB%7CIISB%7CIEPP%7CBPIP%7CLT%7CLMTBL%7CMEID%7CMNBB%7CMPDN%7CN7KB%7CPRII%7CSNPK%7CPRTP%7CMV%7CTFET%7CBILL%7CCEC3%7CCEC5%7CLDBB%7CNWYB%7CNWYB%7CRRAB%7CWTEB%7CZIIY%7CVNNL%7CNBMB%7CBCIV%7CNBCV%7CZIJE%7CCVLL%7CCCN3%7CZIJB%7CZISD%7CZISC%7CDSTS%7CDVLB%7CEEII%7CETL9%7CEDFP%7CETEE%7CZIJD%7CHENV%7CGVHV%7CHSW5%7CLVBPL%7CLVCL%7CLVE1%7CLVRB%7CLVS1%7CLVSBL%7CLVW1%7CLNTL%7CLRML%7CMLNM%7CZIJC%7CNAVN%7CPVTB%7CZIIW%7CRLNL%7CRENV%7CSRNR%7CSVLB%7CRYLL%7CSVLL%7CSVVB%7CSSVB%7CSVL9%7CSVNV%7CZIJF%7CZIJA%7CWVLB%7CDHPP%7CDUP1%7CDUCB%7CDSNB%7CZMAP%7CEEOL%7CECPBB%7CFK1K%7CLHJB%7CHTLL%7CICS1%7CPCRB%7CPEUT%7CRRRB%7CSLCE%7CSLCWS%7CUSLCW%7CSLTB%7COSXB%7CSAPB%7CUBSR%7CVEVB%7CZIAZ%7CZIBD%7CZIAT%7CACO9%7CAJLB%7CANRA%7CAPG1%7CAECO%7CBCDB%7CBECO%7CBSB4%7CBRMB%7CBNTB%7CBRCO%7CCCEE%7CCVFMC%7CZIAY%7CZIBC%7CZIAS%7CCCCZ%7CCCCI%7CCDCO%7CCHTB%7CCSJB%7CCSEC%7CCLUB%7CCCSEC%7CCZJB%7CCCO3%7CCIBB%7CCDCBB%7CDC%7CDLRB%7CLLRB%7CGJSB%7CLCDB%7CDECO%7CDP%7CDPBD%7CDCNPC%7CDRGB%7CECN8%7CEHLL%7CEPTG%7CFCEF%7CCFLP%7CFMTB%7CFTCO%7CZIAU%7CZISG%7CF3KD%7CZIAX%7CCSGB%7CGBCB%7CGWEAC%7CGTCO%7CCGJE%7CZMDJ%7CHTTB%7CHRHL%7CSJAB%7CJAJJ%7CLJTD%7CLNCO%7CLMRB%7CLICO%7CLTVL%7CLLCO%7CMUNCG%7CMMNB%7CMDPM%7CZIRL%7CZIAV%7CZIBA%7CZIBB%7CNTSN%7CPCCO%7CPPCVP%7CPBJB%7CZMFB%7CRBTB%7CRMCF1%7CRM%7CRRSBB%7CSUCC%7CTCEC%7CTGCG%7CZIAW%7CWWCO%7CWRNG%7CAJGC%7CACTP%7CACIA%7CADSB%7CADFB%7CADWT%7CAINA%7CARNW%7CARIG%7CAPN9%7CBESY%7CBIPP%7CBNAN%7CCGDB%7CCHEX%7CCIAZ%7CSCN9%7CCMAM%7CCEAZ%7CCBNNA%7CDTTB%7CDDAZ%7CEACB%7CEMIM%7CZMER%7CEEAZ%7CTAEB%7CFRABB%7CFK19%7CGEAZ%7CGIAZ%7CGAEG%7CGSAZ%7CGVNS%7CINCK%7CITBBB%7CLETB%7CMMAZ%7CMEAZ%7CMLN9%7CMVDN%7CNIAZ%7CNSIS%7CPIP9%7CPTN9%7CPEAZ%7CPMAZ%7CNCA9%7CQCIB%7CRRPP%7CSSAZ%7CSMMNA%7CSPVN%7CSCVSG%7CSEAZ%7CSTN9%7CSVHS%7CSNN8%7CSVL1%7CSPNA%7CSPMT%7CSCWI%7CSCYI%7CYUMA%7CSBYB%7CSSNA%7CSIAZ%7CTPVI%7CTVDC%7CTEAZ%7CTWT9%7CVSVB%7CVGA9%7CWSNA%7CYBDB%7CYEAZ%7CZIIV%7CAODB%7CAEA1%7CAJ%7CAJBB%7CAQTB%7CCCAB%7CZIIR%7CCCBG%7CZMCL%7CZMBC%7CFDTB%7CDHLB%7CBJFB%7CZIIS%7CGIPB%7CLCSB%7CLVOB%7CLAMB%7CZIIT%7CZMFF%7CZMFH%7CRDRB%7CRULL%7CRONB%7CSF%7CSCDP%7CSCPB%7CTAOS%7CBBND%7CBEND%7CBK%7CCRND%7CDNWB%7CDLJB%7CDPD8%7CFEND%7CGF%7CHSND%7CJSJJ%7CLNND%7CMGND%7CMCIG%7CNMCJ%7CNMCR%7CNNTN%7CNMHB%7CNSND%7CUNUU%7CVCTR%7CVAVV%7CWDHW%7CAB%7CAABG%7CBCPB%7CCJPP%7CCSD9%7CZMHC%7CHSS9%7CKSD9%7CMDLM%7CMCTT%7CRCER%7CRCJR%7CSFES%7CTSN9%7CAGNE%7CNBDS%7CBLNE%7CCRNE%7CCOLTE%7CCCCBB%7CDNNE%7CDCBPD%7CFTFF%7CGATEV%7CGCG7%7CGIIB%7CGBNE%7CHLHH%7CKHKK%7CLCHL%7CLENE%7CLJSB%7CLJSW%7CNCNP%7CNPTN%7COENE%7COSNE%7COWHB%7COWHBO%7CPTNE%7CRRNE%7CSCHY%7CSHNE%7CSNP9%7CSJD1%7CWNNE%7CWNW3%7CYNTB%7CARCA%7CADGB%7CCLOO%7CCIKW%7CC1KW%7CCNTB%7CCDAX%7CDRDB%7CDCDG%7CEDTB%7CEM%7CCJAB%7CFLLL%7CGCTB%7CGCPG%7CHSVB%7CHDNB%7CHCNB%7CKKCK%7CKSCM%7CKCSP%7CLGKB%7CLTW9%7CJW%7CLTL9%7CMM%7CMSKS%7CMGSB%7CNKSB%7CODNB%7COHDB%7CPNSB%7CPTPB%7CSLJB%7CSWTB%7CSJNS%7CTCJB%7CTEKS%7CTTMNO%7CRTKT%7CKWDN%7CWE%7CWEBB%7CWEKS%7CZIFV%7CGFAB%7CALTA%7CAVRS%7CMADH%7CAMEA%7CBSLP%7CMBSC%7CBCSP%7CBPSP%7CBUNB%7CBSC9%7CCCNW%7CZIFU%7CCDSP%7CCVMB%7CCHMB%7CCCNMM%7CCHFS%7CMCDT%7CCRSP%7CDGWW%7CDEMN%7CDED9%7CNT%7CDNTBB%7CESCE%7CEDNB%7CEPSC%7CMESC%7CESCSE%7CFFDJ%7CMFCB%7CZIFW%7CFPMM%7CHRGX%7CGUSTV%7CDTHH%7CHSSH%7CHCLB%7CZISI%7CJIPB%7CIDJB%7CLCCB%7CLMMB%7CLSC1%7CLMN9%7CMLRB%7CMMNN%7CMEM7%7CMBMN%7CMDNV%7CMEMN%7CMDMN%7CMMLB%7CWMDS%7CMAMB%7CMTMN%7CMVNB2%7CZIFQ%7CNHGV%7CMCRN%7CNYAT%7COMGPO%7CZIFS%7CPIWX%7CCPJB%7CZMHJ%7CPMN8%7CPSS9%7CZMFI%7CPLAB%7CRFGB%7CMRSC%7CSNMN%7CSVPB%7CSVNB%7CSEH1%7CSCRNC%7CSJPS%7CMSJN%7CSLPS%7CSPES%7CSLLB%7CSP%7CMN%7CSMES%7CSGMN%7CSNS7%7CUSDD%7CWPMN%7CWOLL%7CZMHA%7CMWDN%7CWPW6%7CA8WA%7CAEDI%7CAUDM%7CANTB%7CBNIA%7CBNRBA%7CBNTF%7CICRE%7CICCP%7CLCCD%7CCVWB%7CCHJC%7CCHCC%7CCANB%7CDDFB%7CDGCB%7CDNCC%7CIDCN%7CDEIA%7CDJDD1%7CIDBR%7CDMED%7CFCSF%7CCR%7CGGMM%7CHRHH%7CBHEB%7CHRIA%7CISTD%7CIDID%7CKNIA%7CKJEB%7CLHOL%7CLTRB%7CMCPNO%7CMJIA%7CWT1W%7CNJIA%7CNHTN%7CNWTB%7CNDCRA%7CORDD%7COTGB%7COSTB%7COHOB%7COCOO%7COEIA%7CPCIA%7CQCBJ%7CQCTD%7CROER%7CSBGG%7CSIA9%7CISCE%7CISCJ%7CSCJBS%7CDQ%7CITCT%7CTAIA%7CTRUMW%7CVNTD%7CWCFC%7CKSPR%7CAAMO%7CBRCP%7CBSJB%7CBCJB%7CBDNBB%7CCDMO%7CCPMO%7CKMOV%7CCJMO%7CCJSB%7CMCME%7CCFPS%7CCTMO%7CDGWB%7CDJPM%7CKDRB%7CDSJB%7CDMHB%7CDNFM%7CEIMB%7CFPMO%7CKTVI%7CFSFF%7CGNMWS%7CHCRB%7CMHBJ%7CFMID%7CJCAB%7CJCNB%7CJCJB%7CJEMO%7CJGMB%7CJWEU%7CKCE1%7CKC%7CKCSBB%7CKDEB%7CWKJB%7CLSLC%7CLTL8%7CLEBD%7CLEEB%7CLCLBB%7CLCMCL%7CMCHM%7CMMO9%7CMBMO%7CMDFB%7CMCPNN%7CMJFB%7CMLMM%7CMCJT%7CMLMS%7CMMID%7CMTMO%7CKYTV%7CMNDN%7CNDJB%7CNCJF%7CNCJB%7CNSJB%7CMNCJ%7CNENB%7CNMMO%7COJOB%7COMJB%7COSJA%7CPTBB%7CPJSS%7CPCMS%7CRAYB%7CRDNB%7CMSJT%7CZMFT%7CSCJ8%7CSCJ7%7CSSJS%7CSCJ9%7CSCJS%7CSME9%7CSBRB%7CMSCJ%7CSJLJ%7CSJPB%7CMOAB%7CSDRB%7CSLES%7CSL%7CSPJS%7CMSHB%7CSLSCC%7CZMBU%7CTRCJ%7CUNSS%7CVGM1%7CWJW8%7CWCCS%7CWJMO%7CWCJB%7CMWSS%7CZIQT%7CZIRV%7CZIRB%7CZIQY%7CATOO%7CBHMM%7CBRNN%7CWBDN%7CBEGN%7CBEGNB%7CZIQZ%7CZIQU%7CZIRT%7CZIRU%7CZIRE%7CCHWI%7CCHBC%7CCMATM%7CCJWI%7CBCJW%7CDCWI%7CDJCU%7CWBDB%7CDPAA%7CDRPP%7CMDPB%7CDCNM%7CFOURV%7CWITI1%7CZIRF%7CZIQS%7CZIRA%7CZIRS%7CFJMB%7CFTAB%7CGMFN%7CGBEG%7CGWAN%7CZMDX%7CJCST%7CKOWB%7CKMIB%7CLCEL%7CLCTR%7CLCTBL%7CLCRH%7CLCMS%7CZMGQ%7CLCRBH%7CMEWI%7CMEM6%7CMWSB%7CMJSBM%7CMJSWM%7CMCM6%7CMNBN%7CZIRD%7CZIQV%7CZIRW%7CZIRX%7CZIQX%7CCGNB%7CNSNBB%7COCFG%7COOOB%7COFHB%7CPKPB%7CPFHX%7CBWIX%7CRTPR%7CRCPR%7CSPEA%7CSCRH%7CSSNB%7CSEWE%7CSASX%7CSWI4%7CSUDB%7CSSWI%7CHTPB%7CWNW5%7CWEWI%7CWNTW%7CWFMB%7CWDEE%7CMLJB%7CMD%7CAPIL%7CASIU%7CAQCB%7CALGB%7CARVB%7CASIL%7CAHJT%7CAHPB%7CAEIL%7CAWNI%7CBCRB%7CBWEB%7CBPB8%7CBRIL%7CBILR%7CBC%7CBNWEA%7CBLVB%7CND%7CBNDBB%7CBPIL%7CBENBB%7CBSLBB%7CBLIL%7CBPGG%7CBCIC%7CBAIB%7CBUKB%7CBHPP%7CBJIL%7CBZCB%7CIBSL%7CBSL9%7CBGCB%7CBGJT%7CIBCB%7CBRSL%7CBJCB%7CBJBC%7CCHKB%7CCCC7%7CCHEC%7CCTIL%7CCSE1%7CCSPB%7CCGCB%7CCCC3%7CICIB%7CHPCC%7CCCIL%7CCEC1%7CCJUI%7CCMC7%7CCPOO%7CCRIL%7CCSTB%7CCSTWE%7CCSTBL%7CCWIL%7CCIL8%7CCFBL%7CCBIL%7CCLIL%7CCHSL%7CCJC9%7CCHJB%7CDCCA%7COAL1%7CZMAH%7CCNDD%7CCSLO%7CCURB%7CCN%7CCNWEE%7CDAWB%7CDCIL%7CDCBD%7CIDEN%7CADHB%7CDIUU%7CDLPP%7CDLCC%7CDRRM%7CDSOB%7CDRAB%7CDUSS%7CZMAU%7CDSL9%7CDERB%7CDCI1%7CDPJT%7CDPLB%7CDWBB%7CDCHB%7CDEHB%7CHDGB%7CDLGB%7CDOBB%7CDWSB%7CDGRB%7CDQEC%7CESAA%7CEPTCB%7CESLJ%7CETRB%7CETVB%7CEDIB%7CEJEB%7CIEDN%7CECIL%7CEDC8%7CEHEE%7CEGJK%7CEGTB%7CELVB%7CEPE9%7CRRSE%7CENIL%7CEVRB%7CEIL9%7CFHIH%7CRFLB%7CFPRO%7CFVLB%7CFHJB%7CFRAB%7CFPAW%7CGNIL%7CBYNC%7CGRGB%7CGRGG%7CGENB%7CGLNB%7CGHPB%7CGANB%7CGJIL%7CGCPR%7CGYRB%7CGLBG%7CGURB%7CHCJP%7CHPEH%7CHPPB%7CHICCE%7CDRHH%7CIHML%7CHHWW%7CDH%7CHN%7CHIIL%7CHPNB%7CIHSL%7CHSL9%7CHSLH%7CHERB%7CIHPH%7CIILI%7CAPLL%7CITSB%7CITBSB%7CIWGN%7CINIUC%7CIHPS%7CIPII%7CZMDY%7CJGTC%7CJSIS%7CMJGB%7CJSFB%7CKCCB%7CKCCBB%7CKSKCG%7CLGPS%7CLRCC%7CLCJI%7CLCJBB%7CNS%7CLCNSW%7CLFRB%7CLHRB%7CLKRB%7CLZCB%7CLRMB%7CLBVB%7CLIRB%7CLWRB%7CLRIL%7CLSLL%7CILSL%7CMJIL%7CMDRM%7CMWHB%7CMSLB%7CIMCS%7CMCSB%7CMPHB%7CMDIB%7CJCLF%7CZMEO%7CMDHB%7CMGCB%7CMTNM%7CMPJD%7CMPTB%7CMRVB%7CMAIL%7CNRIL%7CNP%7CNSWEN%7CCNGB%7CNGBC%7CNGWEC%7CENSB%7CNTLL%7CNPMN%7CNHSB%7CNJIL%7CHNNB%7CNRSL%7CNBSB%7CNSDD%7CNHJB%7CNWRB%7CNHBC%7COFJI%7COPFB%7COBSL%7COAKB%7COTPO%7CIOCN%7CODMB%7COGOB%7CPCSB%7CPJTI%7CBL%7CPGI1%7CPHAB%7CPRJR%7CPDTP%7CPEIL%7CJS%7CPJSBP%7CPTOP%7CPHJR%7CPRHB%7CQEQQ%7CULCLL%7CRCHT%7CRAIB%7CGBMB%7CRMBG%7CRNMB%7CRBIB%7CRGMB%7CRBLI%7CRSLR%7CRINB%7CREIL%7CRRSB%7CIRRSB%7CRMJT%7CRMRB%7CRRIL%7CRPRB%7CRJRJ%7CRIRR%7CSAUB%7CSVNDB%7CSGRB%7CSKRB%7CSKYB%7CSOIO%7CSEE1%7CSI%7CSSTR%7CSWEAT%7CZMFN%7CSHI1%7CSES8%7CSCKB%7CSCES%7CSCR1%7CSCCJ%7CSTRB%7CJR%7CSJRBS%7CSLSS%7CSEIL%7CSPIL%7CZMCC%7CTPIL%7CHITB%7CJPBB%7CCTCB%7CTLMM%7CTRAB%7CTIL1%7CTWIH%7CVFPB%7CVLUB%7CVHRB%7CVPAV%7CVJALC%7CVMIM%7CWPWB%7CWTRW%7CWWCB%7CWEIL%7CWRWW%7CWJOP%7CWCPC%7CWHDB%7CWCHB%7CWSLW%7CWCIL%7CWSSLW%7CWPIL%7CWLW1%7CWCSB%7CWJTW%7CWSSL%7CIWSL%7CWMLB%7CWPSS%7CWNTB%7CWDPW%7CWTMM%7CWRIL%7CWIIL%7CANIN%7CZMAG%7CIBHT%7CNBBI%7CBSIN%7CBNMP%7CBEIN%7CIW99%7CCIN9%7CMCTB%7CCRVB%7CCTNB%7CCCIN%7CICIC%7CCIFF%7CCINN%7CCIWW%7CRIN9%7CDDDD%7CDGIG%7CEWRR%7CTEIB%7CTBEB%7CEBJJ%7CEC%7CECPB%7CEEIN%7CTNIB%7CFWEF%7CF5WI%7CFFIK%7CFTII%7CGCG8%7CGNIN%7CIDGN%7CHCFB%7CHBAI%7CHJJB%7CZMCF%7CVHDB%7CIEI1%7CIAII%7CINLB%7CIMBM%7CISTT%7CIBJB%7CIRIN%7CJG%7CJPLL%7CJRIN%7CKOKO%7CLPHA%7CLIEL%7CLKIB%7CIMCB%7CMVDB%7CNDPB%7CCNEC%7CFW%7CNIIB%7CNBI9%7CONI1%7COBN9%7COCNL%7CPCIB%7CPCNT%7CPTIN%7CPTLB%7CPNIN%7CPMCC%7CGPTB%7CPDCP%7CRLIB%7CRRIN%7CSNIN%7CSUSIE%7CSIWUM%7CISBE%7CSBTS%7CSTII%7CSVI1%7CSCJD%7CTHET%7CTFIB%7CZMEP%7CTNIN%7CBEDF%7CTVIV%7CZMFX%7CTSTB%7CZMBT%7CVSCB%7CWPDB%7CWTHW%7CW1F9%7CW1F8%7CZTSB%7CAVTB%7CMAAE%7CAARB%7CAMI9%7CAAND%7CAPO1%7CANMD%7CBAYB%7CBCTWB%7CBEDB%7CBNZB%7CMBG1%7CMBBB%7CBJBB1%7CZBRB%7CCWEB%7CEGRC%7CCCMI%7CCHED%7CCDRC%7CCGRCG%7CSCCE%7CDTAB%7CDBDB%7CDEMI%7CDHMB%7CDJNB%7CDTNB%7CDNBD%7CDDMD%7CDDND%7CEEY9%7CEAMI%7CENSS%7CFPMI%7CFEMI%7CFL%7CFJWEF%7CFXWJ2%7CFW1G%7CFTCB%7CGHTM%7CGHTG%7CGRBJ%7CGREG%7CGRPB%7CGRPWG%7CGTHT%7CGVEA%7CGSTB%7CHRBB%7CHBMI%7CHPSB%7CHRMI%7CMHDB%7CHSHH%7CHIMI%7CHGKK%7CHRDB%7CHDTB%7CJCPB%7CJCPWJ%7CJIJ1%7CZOOB%7CKGWEK%7CLKSB%7CLNHH%7CMLCP%7CLEL5%7CGVLA%7CLLMI%7CDNLL%7CMCBB%7CMNPB%7CMNAB%7CMVNH%7CMLMB%7CMEM5%7CMOTB%7CMDAA%7CMFPD%7CMILB%7CMR9M%7CMLDB%7CMBM7%7CMEVB%7CMPMB%7CMCJB%7CMKCB%7CMCWEM%7CZSHC%7CNCPL%7CNMRR%7CNDSN%7CNWMM%7CRCSA%7CSKCA%7COPRR%7COHJB%7COTTJ%7CPGJG%7CPNRP%7CRCOB%7CBGRB%7CPGMI%7CGCR9%7CRPTB%7CREEB%7CRORB%7CSGNB%7CSNWES%7CSSII%7CSBUB%7CWSUS%7CSAJJ%7CSSMB%7CWAJ1%7CSHSB%7CCSSB%7CSJSS%7CSNHH%7CKUTK%7CTCET%7CTREM%7CTCT7%7CTTSB%7CTC2C%7CVPTB%7CWWKB%7CWBBB%7CWMUK%7CWLBW%7CWWTB%7CZILG%7CAK%7CAKJB%7CAMAB%7CBNOH%7CZMAF%7CBWNB%7CTB%7CBNB2B%7CBCOC%7CBSTC%7CZMAB%7CC7WWD%7CZILD%7CCHSC%7CCECC%7CCHN9%7CCK%7CCCN6%7CCEC4%7CCOAB%7COCAB%7CCBC8%7CCCOH%7CCLDB%7CCDBC%7CCEC2%7CCMOH%7CCPC5%7CCPMBC%7CCCPP%7CCPMM%7CFOCB%7CDLNY%7CDRCC%7CPDSB%7CDDNB%7CDEOH%7CDND8%7CDND9%7CELOH%7CFFEB%7CFSOS%7CFNDD%7CWJWF%7CZILE%7CFOH7%7CGNOH%7CGDTB%7CGVGG%7COGCN%7CCHOH%7CHNNH%7CIMOB%7CICOUT%7CITOH%7CJTJJ%7CJYOY%7CHONB%7CKCGG%7CLCOC%7CLEOH%7CLM%7CLNBL%7CLDNL%7CMSOH%7CMSOO%7CMOJB%7CN4WM%7CZILF%7CONAN%7CNRCC%7CNSC1%7CNBN4%7CNNOB%7CNCNC%7CNRNN%7COROCO%7COVNO%7COPCB%7COOOCT%7COFPB%7CPSPC%7COPCT%7CPTSP%7CPCNW%7CCPDB%7CPDBC%7CPDWEC%7CPDTB%7CPAOB1%7CPJLB%7CRCOC%7CRBCC%7CRTFB%7CRNOH%7CSRSO%7CSTBO%7CSOUA%7CSNSB%7CSBAB%7CSGOG%7CSMOH%7CLSP1%7CSPC1%7CSSA9%7CSSC1%7CKTSB%7CTWNB%7CTCNBC%7CTOH9%7CTRNN%7CTEOH%7CTVNO%7CUANA%7CZMGF%7CVCCB%7COWDN%7CWSSN%7CWNOB%7CWNPO%7CWNOO%7CWA12%7CWNW7%7CWNOH%7CXNCC%7CYEYY%7CBD%7CBEME%7CKBJB%7CWMSB%7CPEME%7CME%7CSNME%7CSJVT%7CBBNH%7CBCTB%7CCTNK%7CCMOB%7CZMAO%7CNDNW%7CZMCY%7CFDD2%7CGNNH%7CHBH8%7CKSKK%7CLTNH%7CMCOO%7CMENH%7CMLNH%7CUL%7CNHUNH%7CNPNH%7CRTNH%7CSOS9%7CNTGB%7CTBNH%7CTTTC%7CVNL1%7CWNH9%7CACIM%7CAEVT%7CBBJR%7CBBRB%7CBRFB%7CBEVT%7CCRS1%7CCBJR%7CCSVB%7CVERB%7CGMOM%7CMJVB%7CMCVT%7CMIVB%7CNMPM%7CNDEB%7CNNT1%7CRBJR%7CRHDB%7CRNBR%7CVSAB%7CBMAB%7CTABBB%7CVVBJ%7CVVM1%7CVBMZ%7CVCVT%7CZIFG%7CZBAA%7CMASA%7CZBAB%7CABMA%7CATMA%7CZBAC%7CZBAD%7CZBAE%7CDAAA%7CAMMA%7CBFPW%7CBTMA%7CBWBBC%7CZBAF%7CZBAG%7CZBAH%7CZBAI%7CPBEB%7CZBAJ%7CZBAK%7CZBAL%7CBEMA%7CBNHB%7CBHBL%7CBOBH%7CBCMA%7CZBAM%7CBIMI%7CZBAN%7CZBAO%7CZBAP%7CZBAR%7CCABC%7CCAPB%7CCT%7CZBAS%7CCRMA%7CZIFF%7CZBAT%7CZBAU%7CCMJB%7CZBAV%7CZBAW%7CDFPBV%7CDHGB%7CDHGBN%7CLMDB%7CDNNB%7CZBAX%7CNHTB%7CDRDD%7CZBAY%7CDCMA%7CDRMA%7CETLL%7CEBSB%7CZBAZ%7CELEF%7CEMAB%7CFBFB%7CZIFD%7CZBBA%7CZBBB%7CMGDT%7CGLMB%7CHPRH%7CZBBC%7CZBBD%7CHNSM%7CHTCM%7CHHSB%7CZBBE%7CZBBF%7CHGHB%7CZMAE%7CCHWC%7CHNSH%7CZBBG%7CZBBH%7CDHH9%7CZBBI%7CZBBJ%7CZBBK%7CNNBBC%7CJPGB%7CZIFE%7CZBBL%7CZBBM%7CLCMA%7CLMKB%7CDLL8%7CLCMB%7CZBBN%7CZBBO%7CZBBP%7CZBBQ%7CZBBR%7CZBBS%7CZBBT%7CZBBU%7CMDCUM%7CMLWB%7CMNM5%7CZBBV%7CZBBW%7CZBBX%7CMRBB%7CMWNB%7CRME2%7CDMMA%7CMFDB%7CMHGB%7CNITB%7CZBBY%7CZIFI%7CZBBZ%7CZBCA%7CZBCB%7CNATB%7CZBCC%7CNAMA%7CZBCD%7CDNMA%7CDNN9%7CZBCE%7CZBCF%7CNWBM%7COJF1%7COCMB%7CPAKB%7CPLQB%7CZIFC%7CPEMA%7CZBCG%7CPFPB%7CZBCH%7CPGP8%7CPTED%7CPBPP%7CAPSB%7CRHSS%7CRSJB%7CZBCI%7CGMRB%7CZBCJ%7CREM1%7CUN%7CRBSS%7CRWEAS%7CZBCK%7CZBCL%7CSNBBB%7CSBMA%7CZBCM%7CZBCN%7CFSEB%7CMSNT%7CZBCO%7CSOCB%7CZBCP%7CDSMA%7CSVMA%7CZBCQ%7CSNMA%7CSENB%7CREME%7CCTVB%7CSEMA%7CZBCR%7CZBCS%7CZBCT%7CSJB1%7CSVSUB%7CLO%7CSNCB%7CZBCU%7CTCLM%7CTDGB%7CZBCV%7CZBCW%7CTTMB%7CZBCX%7CTDM1%7CZBCY%7CVADB%7CDPNB%7CVPNN%7CZBCZ%7CZBDA%7CWTWB%7CWMTB%7CZBDB%7CZBDC%7CZBDD%7CZIFH%7CWBMB%7CWMA8%7CWNMA%7CZBDE%7CWBTBB%7CZBDF%7CDWMA%7CZBDG%7CWEN1%7CZBDH%7CZBDI%7CZBDJ%7CZBDK%7CWHEX%7CWTRB%7CWLAV%7CWLBM%7CWLEBE%7CWLH9%7CWLP8%7CWLWBR%7CWLWR%7CZBDL%7CZBDM%7CZBDN%7CWO%7CBDHP%7CCWRB%7CCTRI%7CRPCB%7CCCRI%7CEGPE%7CGFCCK%7CKCDT%7CNTRI%7CRN1W%7CNPBN%7CPERI%7CZMFC%7CRILB%7CSTRI%7CTPRP%7CVBOS%7CVBCB%7CVBPE%7CWPPB%7CWESB%7CRWRB%7CNWAB%7CAOCB%7CBCZB%7CBNCB%7CBPCT%7CZIBF%7CCBUNW%7CCCC2C%7CCSHB%7CWMCB%7CCRHH%7CCTPB%7CZMAL%7CDADD%7CDEEE%7CEDCD%7CDFFF%7CDGGG%7CDNCN%7CDNCT%7CQCHH%7CDSS9%7CDWW9%7CDWWW%7CDWCT%7CDRNB%7CDTMB%7CDCT8%7CDNCB%7CCECB%7CFFCB%7CFCWB%7CFSSB%7CF61W%7CFMCB%7CGCZB%7CGWPB%7CGRTB%7CHJCB%7CHAVB%7CHC%7CHECT%7CHFNB%7CHHPN%7CHBCT%7CZMET%7CHHCB%7CIWCW%7CMJIB%7CMMCB%7CMCCB%7CMRPB%7CNCAB%7CNNRB%7CNHAB%7CNHRB%7CMFSB%7CDNEB%7CNTBB%7CNHCB%7CNCNB%7CNRBB%7COGCB%7CPVCB%7CPREB%7CMRJB%7CRDPB%7CRCTT%7CWRAB%7CRFPB%7CRNBB%7CSECT%7CSCYB%7CSCZB%7CSFAB%7CTMCB%7CTWTB%7COVTB%7CTTCB%7CVGCB%7CWCVB%7CWAMM%7CWHVC%7CWCTB%7CCWFB%7CWTNB%7CWLBB%7CWMZB%7CYHN1%7CZMGR%7CZIKH%7CAJNY%7CANOB%7CAENN%7CBGN2%7CNARB%7CDANY%7CNBBB%7CBHNY%7CMBNB2%7CBTVB%7CDBBB%7CBHBB1%7CBSB2%7CBEB2%7CDBB9%7CBPPB%7CBRKB%7CDBNY%7CBDTB%7CBNY4%7CBENY%7CBN%7CBPNP%7CCTURR%7CBCCB%7CRTNB%7CCRN8%7CZIKA%7CDCC7%7CCHR2%7CCBC6%7CCSNB%7CCEPB%7CGNCB%7CCHNH%7CCIRC1%7CCANA%7CCZBG%7CCSN2%7CCTHB%7CCLN9%7CCBC5%7CCNY2%7CCSDD+%7CCYUN%7CCONC1%7CCCCC%7CCDSI1%7CDCC8%7CSCAB%7CDCC9%7CC1WN%7CDOMB%7CDNB9%7CSDGB%7CDMCB%7CDMBC%7CDMSB%7CJDMB%7CDNBB%7CDRRB%7CDSNY%7CDENE%7CDESB%7CDDFD%7CDEXB%7CENY4%7CEBSS%7CENOS%7CMONY%7CSNC9%7CEABE%7CEMHB%7CERRB%7CDENY%7CERYB%7CDLPB%7CEEE7%7CEVSB%7CETHB%7CETNY%7CETSH%7CPERP%7CFONY%7CFPRB%7CFPDC%7CFHTB%7CFORB%7CZIKD%7CFSEH%7CGCLC%7CGSPB%7CGAYB%7CGCE1%7CGCRP%7CQGRB%7CGNRG%7CGEPB%7CGCNR%7CDGNY%7CNGSB%7CGBNB%7CGSD1%7CHTNB%7CDHNY%7CHRRB%7CHIHB%7CDHHH%7CHENB%7CHHAWG%7CHCN7%7CHINC%7CINNN%7CZMDU%7CZIJZ%7CZIKE%7CIENE%7CIWCB%7CINY7%7CIRVB%7CIRPB%7CGIDG%7CIBUB%7CJSLB%7CLNJB%7CJC%7COBJB%7CJRMM%7CKTBK%7CKNQCQ%7CLSAGG%7CLBNY%7CDLL7%7CLNYBB%7CNLOB%7CLTLL%7CDLL9%7CLBLB%7CLPSL%7CLNYB%7CLBHB%7CLIAB%7CLINB%7CLAHB%7CLIE1%7CLIPS%7CLERH%7CMNYB%7CMWHH%7CDMNY%7CMPNY%7CMOMM%7CMPNB%7CMHNY%7CMRNB%7CMYW1%7CMAMM%7CMNP8%7CDMPM%7CMVIB%7CMENY%7CDMKM%7CNHL9%7CZIKB%7CDNRN%7CNRRB%7CNYDB%7CNYE1%7CNYN1%7CNYOB%7CNY%7CNYSB%7CNENY%7CITNB%7CNWD1%7CNBLB%7CNNWCE%7CNGNY%7CNWTN%7CNCNN%7CNCN3%7CNCTWY%7CNCEE%7CDNSN%7COYUN%7CUODB%7COIPH%7COPBO%7CDOOO%7COTPB%7COURB%7CODTB%7COBEP%7COBG1%7CPPPUP%7CDPP8%7CDPP7%7CPSNY%7CNPPB%7CPRFB%7CPNNB%7CBPDN%7CPOBH%7CDPNY%7CPVW9%7CPLYT%7CDPCP%7CPWNC%7CSY%7CPSBS%7CPSWES%7CZMDI%7CDPRP%7CPPRB%7CQEXB%7CQGZB%7CQNLB%7CQTRB%7CRNY9%7CRNHR%7CRBSUB%7CTRDB%7CRSHB%7CRVPB%7CRDVH%7CRENY%7CRCHBB%7CRNNY%7CDRRR%7CRCRR%7CRSRB%7CSCS2%7CSTNY%7CSARB%7CNSPS%7CDSS7%7CSCS22%7CSLIUB%7CSSS2S%7CSPS8%7CDSHS%7CDSS8%7CSOTB%7CSNNN%7CSEQB%7CNSHC%7CSDND%7CSTSAO%7CSIAB%7CSIAWS%7CSNY6%7CCPNY%7CSV9S%7CNSNB%7CSLBB%7CSJTS%7CSENY%7CDTT8%7CTVTC%7CZMCW%7CTTT2T%7CAL%7CQTLB%7CTNNN%7CTWRB%7CNTTB%7CUSJB%7CZIKI%7CUEUU%7CVNE1%7CVSHB%7CVPNY%7CVNWCV%7CVILB%7CWWAB%7CWSN7%7CWA%7CWENY%7CWPLL%7CZIJY%7CWBPB%7CWDRB%7CWSBW%7CWSSB%7CWTWW%7CWCN9%7CNDWP%7CWJNY%7CHNTB%7CDYYY%7C2BRR%7C2HRR%7CANEB%7CAJJN%7CASCN%7CAWMW%7CAKNB%7CNACE%7CALNL%7C2RNR%7CBYJ2%7CBTNJ%7CBLNJ%7CBBB8%7CBTBN%7CWBCB%7CNCRB%7CCSNS%7CCYJB%7CCPC2%7CCJNJ%7CCNNJ%7CNJCB%7CCCNJ%7CCCWEC%7CDPPP%7CDTNN1%7CDVNF%7CEBSE%7CEVNJ%7CEMSE%7CENEB%7CHUDB%7CENPB%7CENUB%7CEMNM%7CFLS1%7CFLOS%7CGFNF%7CGRUCC%7CGRVB%7CNGRB%7CGCTW%7CGCTWW%7CHCNJ%7CNHHB%7CNHNB%7CHNN9%7CHRNR%7CHUDD%7CHRALH%7CHCDB%7CHCDWF%7CHOFB%7CIMNM%7CIPNB%7CIPWES%7CIMAS%7CJCEJ%7CNJJ2%7CJJWEJ%7CKRJ2%7CLLNJ%7CLFLL%7CNMSM%7CNJMB%7CNSPR%7CMGWES%7CMPSN%7CMTM2%7CNNMM%7CEYPB%7CNENJ%7CBNB7%7CNCCWB%7CSNRB%7CNTMB%7CMTNB%7CNBNJ%7CNWNW%7CNBWW%7CNSBS%7CNVSE%7CNSNJ%7CZMBG%7CPLNJ%7CPVCL%7CPVTL%7CPENJ%7CZIMZ%7CNPGB%7CPDWB%7CAC%7CRSNR%7CBE%7CRBZB%7CRCNC%7CRPPB%7CRNNJ%7CSCJB%7CSBS6%7CSJTN%7CNSIB%7CSTL2%7CSLWEN%7CSONO%7CSNAPR%7CSTNJ%7CTSNJ%7CTTTB%7CTTN8%7CTSSB%7CTSWES%7CTJRB%7CTNRR%7CNTJB%7CTRJB%7CTTNJ%7CNTBN%7CVCGT%7CWRHB%7CWFJ2%7CWTNJ%7CWMMB%7CWRPW%7CWRUG%7CWSNJ%7CWSN9%7C3SMP%7CZINC%7CA1WW%7CZINM%7CATCC%7CAEPA%7CANPA%7CAUSS%7CPAGB%7CBWUW%7CPBCT%7CJRCBM%7CBLNB%7CPBCN%7CBDWB%7CBATB%7CBNPA%7CBPLB%7CLBCB%7CBELB%7CBFMM%7CCPIS%7CCNPA%7CZINN%7CCVMM%7CDT%7CCDTBB%7CCHDB%7CCCPO%7CCSC21%7CCHLP%7CCZSB%7CCZVB%7CCVSVW%7CPCLB%7CCMLB%7CCMCB%7CCSPA%7CCTYB%7CJRCCP%7CTCSD%7CCJM1%7CDAPA%7CDCCB%7CDISB%7CJDLB%7CLDNB%7CDNMB%7CDPP9%7CDPUBP%7CDPSS%7CDRVB%7CDNDD%7CDCDT%7CPDLB%7CDWLB%7CDYPB%7CENNB%7CETNB%7CEPGG%7CECCB%7CEZCB%7CECLE%7CEEPA%7CET%7CHESB%7CETEB%7CETWEE%7CFRFB%7CZINA%7CF4WY%7CQFPB%7CGKGUE%7CGVPB%7CGTCB%7CLNGB%7CGLNN%7COAAP%7CHBIB%7CHEPA%7CLNBB%7CHVPB%7CHPA1%7CHSPS%7CHSUP%7CHSBU%7CHSHB%7CHWPB%7CLNOB%7CLNHB%7CZIND%7CIOSI%7CDPIB%7CJSPA%7CJDBB%7CJKTB%7CJEPA%7CKRKB%7CKNPB%7CKSTK%7CKNGB%7CKVNM%7CKZPB%7CLVCLA%7CLVZB%7CPLHB%7CLC%7CLTP9%7CKLTB%7CLDRB%7CLVNN%7CLEPA%7CLLCW%7CMLLB%7CMLSLB%7CMLKB%7CPMLB%7CMJPA%7CMTPA%7CMEPB%7CMRCB%7CPPMB%7CAMCB%7CMVMM%7CMPJM%7CMAEB%7CMSM1%7CZIMY%7CN1WWP%7CZINO%7CZIRQ%7CNCPB%7CNHGB%7CNEHB%7CGLEB%7CNDCB%7CBGHB%7CUDCB%7CHNDB%7CNMDB%7CNWIB%7CNAVB%7CNHJM%7CNEZB%7CNPBB%7CNOTB%7CNSMM%7CWORB%7CONPB%7COXTB%7CPKLB%7CPRKB%7CHRNB%7CPNBH%7CPNWEH%7CZIRR%7CZMAW%7CPHPM%7CPTSM%7CPCTN%7CPPXB%7CPPA9%7CPCP7%7CDN%7CPEP9%7CPI%7CPMPA%7CPTPA%7CPCCB%7CPCJH%7CPEPA%7CPG%7CPTRB%7CALPA%7CPMJB%7CPRS4%7CPRPB%7CPREHP%7CPAJM%7CPFCB%7CCPOB%7CPSPP%7CQUADV%7CZMFK%7CPRCB%7CRHWW%7CLREB%7CREVB%7CRRPA%7CLNRB%7CSUCB%7CSEPA%7CSPCP%7CSRMUM%7CSHPA%7CSSSP%7CSIPA%7CSMPM%7CSSLB%7CSHRS%7CSBKB%7CSGFB%7CSHNP%7CSUBB%7CSUVB%7CSCIB%7CHZSB%7CTNPP%7CTEMM%7CTHNN%7CWB%7CTSWW%7CSRTB%7CTTBS%7CJRCTT%7CTWAB%7CTWCB%7CTTKB%7CTTEB%7CTTNB%7CTKSB%7CTTWB%7CTRCY%7CTDEM%7CTRGB%7CAVAB%7CVIMB%7CKVNB%7CVVH1%7CLNMB%7CWIHB%7CWWNWN%7CWCLB%7CWSWB%7CWCQB%7CWGVB%7CWMPM%7CNAEB%7CPYNB%7CYK%7CYWRB%7CYKDB%7CWHAS%7CZIED%7CAPKY%7CAMDD%7CANLL%7CBGEB%7CBLLL%7CCNDC%7CCCNL%7CZIEC%7CCKNJ%7CCCML%7CCJKY%7CCDC7%7CDIAB%7CBGDB%7CFCTB%7CZIEE%7CKGNG%7CGDTG%7CHKGB%7CGCNW%7CGCGB%7CHDEB%7CHZHB%7CHCLN%7CIJSJ%7CJJNJ%7CJTGO%7CKYPB%7CKSBBB%7CLCHN%7CLELB%7CLIKI%7CLEL7%7CLH%7CLHLBB%7CLCKY%7CLEOB%7CLEL6%7CLMLV%7CMCRW%7CMMKM%7CKDNB%7CMNKY%7CMABB%7CZIEB%7CNJCC%7CKNDB%7CNEEB%7CNOLSL%7CNHK1%7COELB%7COMIB%7CONHB%7CPEKY%7CZMFA%7CPNKY%7CRLKB%7CRRRR%7CSELB%7CSNKY%7CSLKL%7CSMTT%7CSSKY%7CTTCC%7CTBBB1%7CWCOB%7CWSKY%7CZIOI%7CZIOA%7CZINX%7CZIOD%7CANTN%7CMCAD%7CBTMM%7CBLTN%7CCCJJ%7CC3WM%7CZIOE%7CZIOK%7CZIOB%7CC1WJ%7CZINU%7CCCC2B%7CCETN%7CCHAT%7CCPTN%7CCBPB%7CCDBB%7CCA%7CCABM%7CCAWEM%7CCNTN%7CCCC2A%7CCDHB%7CTDPA%7CMDTB%7CETMNK%7CETJJ%7CZIOC%7CZIOH%7CZINZ%7CZINW%7CFLTN%7CGSCC%7CGKBJ%7CGLSB%7CHNTN%7CHCCB%7CHNDBB%7CJTEJ%7CKEKK%7CKETN%7CKX%7CKNSBB%7CLPTN%7CLDTN%7CMTTB%7CMETN%7CTMMN%7CTMCN%7CMPSS%7CMVNN%7CNETN%7CTTMN%7CNPM9%7CNPN9%7CNSN9%7CZINV%7CZIOJ%7CZIOG%7CZINY%7CPTTN%7CNHLL%7CNTN7%7CTORB%7CPPIT%7CRCNB%7CRRTN%7CMSM6%7CMCEE%7CTTTN%7CVHNN%7CWTMNN%7CBEB3%7CBAWF%7CBCCC%7CC1WNA%7CC2WH%7CCPDA%7CCDLB%7CCPMS%7CCPC2M%7CCDPB%7CDCMS%7CDMOO%7CDTLB%7CDDTB%7CDCTO%7CEJMB%7CGWCB%7CGMEG%7CHEMS%7CIETI%7CJANA%7CJEJJ%7CLTPP%7CMLLC%7CMCSC%7CMSMM%7CMBJB%7CMLNA%7CMMN6%7CPMPB%7CMPWEG%7CZMHB%7CNAGN%7CNRN9%7CZMGJ%7CNSJJ%7COEO1%7CPNHH%7CPIMS%7CRSMS1%7CSCTF%7CSHKB%7CMSDN%7CSPZU%7CBX%7CSHBB%7CTEMS%7CWPTB%7CWTMS%7CWCJL%7CABA6%7CANSB%7CBEAL%7CABMN%7CBI%7CBNWEB%7CBTAL%7CCW5K%7CCW1H%7CUEH1%7CCBNB%7CCTAL%7CDLHB%7CDMEJ%7CDSAB%7CDDAB%7CDOTH%7CDEBD%7CDEAL%7CENTL%7CEFAL%7CFAAL%7CHEAL%7CHUTB%7CHTWEH%7CJVNB%7CMLAL%7CLNLN%7CMEAL%7CMEM9%7CN1WNA%7CNCAA%7CNJNG%7COPAN%7COANB%7CPJPB%7CMBRB%7CPRWEM%7CAMRB%7CSTCB%7CSCNA%7CSASCT%7CFPJB%7CVTNB%7CUVM1%7CRWPB%7CZIMF%7CZIML%7CAENB%7CAEA7%7CATOB%7CARCV%7CAAFF%7CAMOB%7CAAAB%7CEEBBB%7CBTB2B%7CCNJCU%7CZIMK%7CZIMG%7COCDP%7CDAOB%7CDOCOK%7CDTPB%7CDBDD%7CDDDB%7CESEE%7CENEE%7CESCC%7CZIMJ%7CZIMD%7COFLB%7CFGTB%7CGLVV%7COGDN%7CGDHB%7CZISH%7COJRB%7COBNB%7CLCOB%7CMNCD%7CMNRB%7COMCS%7CMTDB%7CZISF%7CZIMI%7CN4KO%7CZIME%7CNTOK%7CNSOK%7COOCE%7CODNN%7COK%7CPVDD%7CPJCP%7CZIMH%7CPDJ1%7CPDNS%7COSNS%7CNPSS%7COTDP%7CTEOK%7CTLWB%7CTTOK%7CVDJV%7CWNDB%7CWDNW%7CWNWW%7C1TTDH%7CZIPL%7CZIOM%7CZIOQ%7CWFAA%7CZIPO%7CZIPF%7CZIOT%7CA2KA%7CZIPU%7CZIPJ%7CAEA4%7CARNB%7CARNBB%7CAFNDD%7CALHED%7CALEDD%7CAOCE%7CAPHE%7CAGSB%7CADAB%7CAENJ%7CAATX%7CTAPB%7CAEA3%7CAGNB%7CAGTB%7CAMTA%7CAATB%7CAMGB%7CAOTB%7CADRB%7CTACJ%7CAASB%7CAETX%7CAVTX%7CCZBB%7CBCYB%7CBTSB%7CBT%7CBEB5%7CBTX7%7CBELEX%7CBTPB%7CBEXB%7CBSHJB%7CBSHBT%7CBCN6%7CBWPB%7CBJB9%7CBNHBT%7CBCCTN%7CBZSB%7CBZFB%7CBCAH%7CBATX%7CBEB4%7CBHTX%7CBWBB%7CBNTX%7CBBTX%7CCTTX%7CCLTX%7CCCS2%7CC5KS%7CZIPR%7CZIPM%7CZIOR%7CZIOL%7CZIPT%7CZIPE%7CC1KH%7CZIPI%7CZIOV%7CCCPG%7CCRTX%7CCSH9%7CCTRCB%7CCAVB%7CCRC7%7CCCTX%7CCCSS%7CCLTT%7CCJTX%7CCEXB%7CCGTX%7CCFSB%7CCCCB%7CCCCT%7CTCCE%7CTCDS%7CCTXB%7CCRTT%7CC33D%7CC3KH%7CCFSH%7CCCMCH%7CTCC9%7CCCMCC%7CTCCMC%7CCYPY%7CCCMKH%7CCSC2%7CDCHH%7CNDSB%7CDSKFF%7CDTTX%7CDTL9%7CDETX%7CDM%7CDMNBB%7CDYNB%7CDPBB%7CDELB%7CDRCB%7CDRCBB%7CFPTX%7CEGLB%7CMCOB%7CEXAB%7CEDRE%7CEEE6%7CEMAA%7CEHBB%7CTEPE%7CEPTB%7CESOB%7CTECB%7CENJB%7CFRTX%7CFMLB%7CFBSB%7CBPFB%7CFWE1%7CST%7CFWST%7CZIOS%7CZIOO%7CZIPG%7CZIPP%7CZIPK%7CFAHH%7CFSRPF%7CFJTB%7CFETX%7CGDRG%7CGDNB%7CGCDNG%7CGETX%7CGMTX%7CTGRR%7CGRMB%7CGSSG%7CGCSB%7CGHWH%7CGHBB%7CHHTX%7CTHCN%7CHDH9%7CHDSS%7CHTX7%7CHMTM%7CHCCT%7CHCBF%7CHETX%7CHTX8%7CHGTX%7CHOVB%7CHITX%7CIRTX%7CJCHT%7CJDPB%7CJNTX%7CKSTB%7CKCTB%7CKDTB%7CKNHB%7CKWOB%7CKSHH%7CLAEB%7CLASB%7CLVDHH%7CLCPT%7CLCLM%7CLFOLS%7CLHPB%7CLHSB%7CLWPB%7CLEL4%7CLRTB%7CLLLB%7CLLTX%7CTLNT%7CLEJB%7CLCJL%7CTLSL%7CLTJB%7CLAJB%7CLETX%7CLTNB%7CMPTX%7CMNMB%7CTXMB%7CMCGB%7CMEXB%7CMTTX%7CMNTX%7CFMMB%7CMDNM%7CMOEM%7CMRTB%7CTMMB%7CMVTC%7CMMM3%7CMWIB%7CMTXM%7CMPDB%7CZIPD%7CZIPQ%7CZIOP%7CZION%7CZIPS%7CZIPN%7CZIPH%7CZIOU%7CNAFMD%7CNGBS%7CNCFBD%7CNGMD%7CNICD%7CNLFMD%7CNGDAL%7CNPMWD%7CNRLHD%7CNRRD%7CNWRED%7CNBZB%7CNCNS%7CNTCB%7CNHTX%7CNWTX%7CNCRS%7COCPB%7COACS%7COAMB%7COEOO%7COLOO%7COCAA%7COPTX%7CPHPP%7CPAEE%7CPWTX%7CPTNB%7CPCPB%7CPCZB%7CPLJB%7CPGTX%7CPDHB%7CPETX%7CPITX%7CPSCP%7CPANP%7CPTX8%7CPHPB%7CPPTX%7CRPTX%7CRFTF%7CRTXR%7CRCDD%7CWTXW%7CROEB%7CRCN4%7CRCHBG%7CRLTB%7CRCHB%7CRDHB%7CSAE9%7CSAGB%7CSACB%7CTSAE%7CSAEC%7CSMDR%7CSGEB%7CSES5%7CSATA%7CSTTAK%7CSJTX%7CSTTX1%7CSRTX%7CSOBB%7CSETX%7CSCOH%7CTSLS%7CSRSS%7CTGTZ%7CTGBT%7CTCSB%7CTDLO%7CPMTB%7CTRPB%7CZMFY%7CUSTXU%7CUMRR%7CHVMS%7CVTCX%7CVALV%7CVA%7CWTVB%7CWETX%7CWTHB%7CWTHBW%7CWCZB%7CWDLB%7CWAXB%7CWDWB%7CWTTX%7CWPOB%7CWUEB%7CWFEW%7CWFTB%7CWFTR%7CWCDQ%7CXHTH%7CYNV1%7CYHNH%7CZIAI%7CZIAE%7CZIAC%7CAJAA%7CADGL%7CNADGF%7CADGWL%7CATAR%7CATBL1%7CATFF%7CALAL%7CBNMM%7CBCDR%7CBHUS%7CBDBB%7CBSAUM%7CCSHC%7CCNCC%7CCICC%7CC5KF%7CZIAD%7CZIAF%7CCEAR%7CCRAR%7CDCSY%7CDSHA%7CDWHB%7CEDNT%7CELAR%7CFFWB%7CFSEF%7CZIRY%7CZIAG%7CGDAR%7CGTAA%7CHJAJ%7CHSTA%7CHSWB%7CJPJJ%7CJEAR%7CJSJ1%7CALRE%7CLDAR%7CAMDR%7CMMAR%7CMNAA%7CMNNA%7CM3KF%7CZIAH%7CZIRZ%7CNINN%7CANCP%7CNATF%7CNBFF%7CANWEA%7CPDPB%7CPEPB%7CPBCP%7CPACV%7CRMNR%7CBCBB%7CSRH9%7CSVAR%7CHLSS%7CSTRF%7CASMN%7CSDLB%7CSTH1%7CSAR8%7CTNAN%7CTNBCP%7CUFLL%7CVBCD%7CAWCEL%7CWVBV%7CWEOD%7CWHJB%7CWHPW%7CWHSF%7CAMLA%7CWGNO%7CAPTC%7CAD%7CABLA%7CANOEN%7CAELA%7CAMPB%7CATDA%7CAJMM%7CLBDE%7CBREB%7CBDND%7CBPTB%7CWWL4%7CNSRB%7CLCPS%7CMCDB%7CDINB%7CDNBA%7CDSH1%7CDCLA%7CENLA%7CFPGF%7CFBTB%7CACAA%7CGJGG%7CHML1%7CKHLA%7CLLA9%7CLELA%7CLASTL%7CLLCE%7CLDLB%7CLMNL%7CMCMN%7CMPHM%7CMELA%7CNOBB%7CNOE1%7CNDLA%7CZMBB%7CPPSH%7CPGLA%7CRATB%7CLRBN%7CSELA%7CSDSUB%7CSDNS%7CSBVA%7CSTNC%7CSTLA%7CTNLA%7CTP%7CTPBN%7CTPWEA%7CUMNN%7CVPGB%7CVLLL%7CVTLA%7CZPZZ%7CAINT%7CZCFF%7CAMN2A%7CAMB8%7CEBFN%7CDST9%7CDSTB%7CFCN4%7CFCB9%7CMPT9%7CMPTB2%7CPNA2P%7CPMN6%7CPMBN%7CZCAB%7CATNB%7CATYB%7CZCAI%7CZCDH%7CZCAF%7CAMBB%7CAMNB%7CASRB%7CTDNB%7CZCEO%7CZCCY%7CBICB%7CBLRB%7CTNBB%7CBBYB%7CBBN2%7CBSN5%7CZCDG%7CBMZB%7CBIRU%7CBIZWIRE%7CZCDO%7CZCEK%7CZCEP%7CCTGB%7CCTMB%7CCMGB%7CZCCF%7CZCAJ%7CCQDB%7CCDJB%7CCDRB%7CZMCN%7CCUJB%7CZCDM%7CZCFE%7CZCEQ%7CZCER%7CZCDR%7CZCFH%7CZCDW%7CZCEF%7CNDMN%7CDJO1%7CDJS9%7CZCFI%7CZCAO%7CZCAP%7CZCAQ%7CZCBV%7CEBAB%7CEBNB%7CEBCB%7CZCFD%7CZCFJ%7CEQUB%7CFDW1%7CFWD9%7CZCAR%7CFPGB%7CZCAT%7CZCFL%7CZCBE%7CZCCH%7CHDAB%7CZCCJ%7CHPN8%7CHPN7%7CHYRB%7CHEWU%7CRDMB%7CZCAV%7CZCCN%7CINWB%7CIBDB%7CIDGB%7CIMWB%7CZCAW%7CISOB%7CZCAX%7CKMN8%7CKMBK%7CZCAZ%7CLWKB%7CMNN7%7CZCBA%7CMARB%7CDMJB%7CMLTC%7CMNA6%7CMTEN%7CZCDD%7CZCDA%7CMNA7%7CMMEB%7CMNEY%7CMBKB%7CMVNB%7CTMTB%7CNMNB%7CZCBD%7CZCBB%7CZCBC%7CNBRB%7CTMWB%7COTNB%7CPU98%7CZCDK%7CNUSB%7CPWUP%7CTPAB%7CPPLB%7CPNA2%7CQWNQ%7CQWBQ%7CZCES%7CRGRB%7CRCE9%7CRCEB%7CZCDQ%7CZCDT%7CZCDU%7CSMN2S%7CSDNB%7CSWN8%7CSWBN%7CSNA2%7CSFUB%7CZCFC%7CZCDZ%7CZCEA%7CZCEB%7CZCEC%7CZCEE%7CFEN8%7CTFOW%7CFSNS%7CTITE%7CTMZB%7CTBUS%7CZMFM%7CTMBB%7CUNA2%7CVLJB%7CZCEH%7CZCBL%7CZCFN%7CZCEL%7CWWD9%7CZCFO%7CZCFP%7CMINN%7CAULL%7CADUD%7CBAUT%7CBNA2%7CCNTU%7CEDEA%7CGU98%7CGU9Q%7CLUCK%7CSULF%7CSBN5%7CTVN9%7CVUGU%7CBTKB%7CPARB%7CPSYY%7CWMN3%7CWMN2%7CASPJ%7CAFLR%7CAFTB%7CANUB%7CAHUB%7CAFJB%7CANUN%7CACN8%7CALNN%7CALN7%7CARMB%7CISRB%7CCACR%7CCEUB%7CDECB%7CDFNB%7CFJFF%7CFEDB%7CFFAJ%7CFSNTY%7CFNUN%7CGOVB%7CINUB%7CJFQB%7CMTMB%7CMNUB%7CMIPBB%7CMAGB%7CMTE9%7CNAN9%7CNWCR%7CNVTB%7CNJCO%7CPJAW%7CREPB%7CSNUN%7CSPSB%7CSWNN%7CSASN%7CSWMN%7CTSJB%7CAPAB%7CBBAB%7CCUM9%7CZCAL%7CCOPB%7CZCAS%7CKR%7CMCSS%7CSN%7CZCBI%7CTNS1%7CUVWB%7CZCBK%7CZUAA%7CUCHB%7CUERB%7CUETB%7CUIIB%7CUNTB%7CUSIB%7CWSOB%7CAASN%7CPOSB%7CSIN7%7CSNW1%7CWURD%7CCNEB%7CWEEU%7CUSLB%7CGDUG%7CGWUW%7CSNNI%7CBTN9%7CCBSB%7CCRSB%7CCNBB%7CCNNB%7CCNIB%7CCNFB%7CFDCB%7CDRRU%7CFOXB%7CZCAU%7CSNBB%7CNR%7CNPR9%7CNPRW%7CNBCB%7CJLNB%7CARN7%7CANA2%7CAOFN%7CADLB%7CAMB9%7CCFIR%7CCNA2C%7CCCA2C%7CCWN6%7CCNY7%7CCSMB%7CCAN4%7CDBNN%7CDRSU%7CEDWB%7CEU9E%7CEAEN%7CAFTA%7CEFPN%7CIFCI%7CFSUM%7CFFMF%7CFAFB%7CGNW%7CGNA2W%7CHENN%7CICCA%7CINN9%7CJSD1%7CKNSN%7CERN7%7CMNA2M%7CMMMNA%7CMNN5%7CNMPRM%7CNIHN%7CNJDW%7CNJHW%7CNJHWW%7CNJW1%7CNDC9%7CNRU9%7CNORX%7CNMWN%7CNRUR%7CNNAW%7CNYUY%7CNMX2%7CNWEC%7CNGN4%7CNBN8%7CENN8%7CNNA2NW%7CONA6%7CPFWB%7CPNN9%7CRNA2%7CRRR2%7CRNSB%7CRUNR%7CSEPN%7CS2P2N%7CSVAB%7CSMNN%7CSATH%7CIRN5%7CESN7%7CFENB%7CUONL%7CUSTB%7CVFUF%7CWIWW%7CIPI7%7CWNA2%7CZMGT";
        }
    }
}
