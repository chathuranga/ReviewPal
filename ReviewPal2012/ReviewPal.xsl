<?xml version='1.0' encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
<html>
<head>
    <title>Code Review :: </title>
	<style type="text/css">
    .body{background-color:White;}
    .summary{width:100%;font-weight:bold;background-color:White;border: thin solid #808000;color:#FAFCFE}
    .outer{font-weight:normal;color:#6D5757;background-color:#FFDFBF}
    .inner{font-weight:normal;color:black;}
    .reviewTable{border: thin solid #C0C0C0; width:100%}
    .headerRow{color:white;background-color: #800000;font-weight:bold;text-align: center}
    .reviewRow{background-color:#FFDFBF;color:black;}
    .rAligned{text-align:right;}
    .data{visibility:hidden}
  </style></head>
<body class="body">
<div class="summary">
	<table>
		<tr><td colspan="3" class="headerRow">Review Summary</td></tr>
        <tr class="outer"><td>Project Name : <label class="inner"><xsl:apply-templates select="CodeReview/ProjectName"></xsl:apply-templates></label></td><td>Reviewed By : <label class="inner"><xsl:apply-templates select="CodeReview/ReviewedBy"></xsl:apply-templates></label></td></tr>
        <tr class="outer"><td>Project Code : <label class="inner"><xsl:apply-templates select="CodeReview/ProjectCode"></xsl:apply-templates></label></td><td>Reviewed Date : <label class="inner"><xsl:apply-templates select="CodeReview/ReviewedDate"></xsl:apply-templates></label></td></tr>
        <tr class="outer"><td>Work Product Name : <label class="inner"><xsl:apply-templates select="CodeReview/WorkProductName"></xsl:apply-templates></label></td><td>Status : <label class="inner"><xsl:apply-templates select="CodeReview/ReviewStatus"></xsl:apply-templates></label></td></tr>
		<tr class="outer"><td>Work Product Version : <label class="inner"><xsl:apply-templates select="CodeReview/WorkProductVersion"></xsl:apply-templates></label></td><td>Review Preparation Effort : <label class="inner"><xsl:apply-templates select="CodeReview/ReviewPreparationEffort"></xsl:apply-templates></label></td></tr>
		<tr class="outer"><td>Work Product Size (ekloc) : <label class="inner"><xsl:apply-templates select="CodeReview/WorkProductSize"></xsl:apply-templates></label></td><td>Review effort : <label class="inner"><xsl:apply-templates select="CodeReview/ReviewEffort"></xsl:apply-templates></label></td></tr>
		<tr class="outer"><td>Work Product Release Date for Review : <label class="inner"><xsl:apply-templates select="CodeReview/WorkProductReleaseDateForReview"></xsl:apply-templates></label></td><td>Rework effort : <label class="inner"><xsl:apply-templates select="CodeReview/ReworkEffrot"></xsl:apply-templates></label></td></tr>
		<tr class="outer"><td>Review Action Taken By : <label class="inner"><xsl:apply-templates select="CodeReview/ReviewActionTakenBy"></xsl:apply-templates></label></td><td>Review Efficiency : <label class="inner"><xsl:value-of select="format-number((CodeReview/ReworkEffrot + CodeReview/ReviewPreparationEffort)*100 div count(//Review),'#.00')"></xsl:value-of></label></td></tr>
		<tr class="outer"><td>Review Action Taken Date : <label class="inner"><xsl:apply-templates select="CodeReview/ReviewActionTakenDate"></xsl:apply-templates></label></td><td></td></tr>
    </table>
	<table>
	<tr class="headerRow"><td colspan="2">Review Details</td><td colspan="2">Defect Status Analysis</td><td colspan="2">Defect Type Analysis</td><td colspan="4">Defect Injected Phase Analysis</td></tr>
	<tr class="outer">
	<td></td><td ></td><td></td><td></td>
	<td></td><td></td>
	<td></td>
	<td>Major</td><td>Medium</td><td>Minor</td>
	</tr>
	<tr class="outer">
		<td>Total No of Suggestions</td><td class="inner"><xsl:value-of select="count(//Review[Comment='Suggestion'])"/></td>
		<td>Open</td><td class="inner"><xsl:value-of select="count(//Review[Status='Open'])"/></td>
		<td>Logical</td><td class="inner"><xsl:value-of select="count(//Review[DefectType='Logical'])"/></td>
		<td>Initial Project Setup</td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='Initial Project Setup' and Severity='Major'])"/></td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='Initial Project Setup' and Severity='Medium'])"/></td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='Initial Project Setup' and Severity='Minor'])"/></td>
	</tr>
	<tr class="outer">
		<td>Total No of Errors</td><td class="inner"><xsl:value-of select="count(//Review[Comment='Error'])"/></td>
		<td>On Hold</td><td class="inner"><xsl:value-of select="count(//Review[Status='On hold'])"/></td>
		<td>Incomplete</td><td class="inner"><xsl:value-of select="count(//Review[DefectType='Incomplete'])"/></td>
		<td>Project Initiation</td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='Project Initiation' and Severity='Major'])"/></td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='Project Initiation' and Severity='Medium'])"/></td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='Project Initiation' and Severity='Minor'])"/></td>
	</tr>
	<tr class="outer">
		<td>Total</td><td class="inner"><xsl:value-of select="count(//Review/Comment)"/></td>
		<td>Closed</td><td class="inner"><xsl:value-of select="count(//Review[Status='Closed'])"/></td>
		<td>UI</td><td class="inner"><xsl:value-of select="count(//Review[DefectType='UI'])"/></td>
		<td>Requirement Analysis</td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='Requirements Analysis' and Severity='Major'])"/></td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='Requirements Analysis' and Severity='Medium'])"/></td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='Requirements Analysis' and Severity='Minor'])"/></td>
	</tr>
	<tr class="outer">
		<td></td><td></td>
		<td>Rejected</td><td class="inner"><xsl:value-of select="count(//Review[Status='Rejected'])"/></td>
		<td>Exception Handling</td><td class="inner"><xsl:value-of select="count(//Review[DefectType='Exception Handling'])"/></td>
		<td>Architecture and Design</td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='Architecture and Design' and Severity='Major'])"/></td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='Architecture and Design' and Severity='Medium'])"/></td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='Architecture and Design' and Severity='Minor'])"/></td>
	</tr>
	<tr class="outer">
		<td></td><td></td><td></td><td></td>
		<td>Documentation</td><td class="inner"><xsl:value-of select="count(//Review[DefectType='Documentation '])"/></td>
		<td>Implementation</td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='Implementation' and Severity='Major'])"/></td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='Implementation' and Severity='Medium'])"/></td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='Implementation' and Severity='Minor'])"/></td>
	</tr>
	<tr class="outer">
		<td></td><td></td><td>
		</td><td></td><td></td>
		<td class="inner"></td><td>QA Testing</td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='QA testing' and Severity='Major'])"/></td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='QA testing' and Severity='Medium'])"/></td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='QA testing' and Severity='Minor'])"/></td>
	</tr>
	<tr class="outer">
		<td></td><td></td><td>
		</td><td></td><td></td>
		<td class="inner"></td>
		<td>Transition Phase</td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='Transition Phase' and Severity='Major'])"/></td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='Transition Phase' and Severity='Medium'])"/></td>
		<td class="inner"><xsl:value-of select="count(//Review[InjectedPhase='Transition Phase' and Severity='Minor'])"/></td>
	</tr>
		<tr class="outer">
		<td></td><td></td><td>
		</td><td></td><td></td><td></td>
		<td class="rAligned">Total</td>
		<td class="inner"><xsl:value-of select="count(//Review[Severity='Major'])"/></td>
		<td class="inner"><xsl:value-of select="count(//Review[Severity='Medium'])"/></td>
		<td class="inner"><xsl:value-of select="count(//Review[Severity='Minor'])"/></td>
	</tr>
	</table>
    </div><br/>
	<table class="reviewTable">
		<tr class="headerRow">
			<td>#</td>
			<td>Description</td>
			<td>Status</td>
			<td>DefectType</td>
			<td>InjectedPhase</td>
		</tr>
		<xsl:apply-templates select="//Review" />
	</table>
  <div>
    <br></br>
    Created with <a href="http://visualstudiogallery.msdn.microsoft.com/d1e40c49-da36-42a5-8d5a-4ebe1feabbc9">ReviewPal</a>
  </div>
  <div class="data">
	  <Data id="ReviewPalData">
	  </Data>
  </div>
</body></html>
</xsl:template>
<xsl:template name="Review" match="//Review">
	<tr class="reviewRow">
		<td><xsl:value-of select="ReviewId"/></td>
		<td class="inner"><xsl:value-of select="Description"/></td>
		<td class="inner"><xsl:value-of select="Status"/></td>
		<td class="inner"><xsl:value-of select="DefectType"/></td>
		<td class="inner"><xsl:value-of select="InjectedPhase"/></td>
	</tr>
</xsl:template>
</xsl:stylesheet><!-- Stylus Studio meta-information - (c) 2004-2009. Progress Software Corporation. All rights reserved.

<metaInformation>
	<scenarios>
		<scenario default="yes" name="Scenario1" userelativepaths="yes" externalpreview="no" url="..\Temp\Sample.xml" htmlbaseurl="" outputurl="" processortype="saxon8" useresolver="yes" profilemode="0" profiledepth="" profilelength="" urlprofilexml=""
		          commandline="" additionalpath="" additionalclasspath="" postprocessortype="none" postprocesscommandline="" postprocessadditionalpath="" postprocessgeneratedext="" validateoutput="no" validator="internal" customvalidator="">
			<advancedProp name="sInitialMode" value=""/>
			<advancedProp name="bXsltOneIsOkay" value="true"/>
			<advancedProp name="bSchemaAware" value="true"/>
			<advancedProp name="bXml11" value="false"/>
			<advancedProp name="iValidation" value="0"/>
			<advancedProp name="bExtensions" value="true"/>
			<advancedProp name="iWhitespace" value="0"/>
			<advancedProp name="sInitialTemplate" value=""/>
			<advancedProp name="bTinyTree" value="true"/>
			<advancedProp name="bWarnings" value="true"/>
			<advancedProp name="bUseDTD" value="false"/>
			<advancedProp name="iErrorHandling" value="fatal"/>
		</scenario>
	</scenarios>
	<MapperMetaTag>
		<MapperInfo srcSchemaPathIsRelative="yes" srcSchemaInterpretAsXML="no" destSchemaPath="" destSchemaRoot="" destSchemaPathIsRelative="yes" destSchemaInterpretAsXML="no">
			<SourceSchema srcSchemaPath="..\Temp\Sample.xml" srcSchemaRoot="CodeReview" AssociatedInstance="" loaderFunction="document" loaderFunctionUsesURI="no"/>
		</MapperInfo>
		<MapperBlockPosition>
			<template match="/">
				<block path="html/body/div/table/tr/td/label/xsl:apply-templates" x="362" y="28"/>
				<block path="html/body/div/table/tr/td[1]/label/xsl:apply-templates" x="282" y="28"/>
				<block path="html/body/div/table/tr[1]/td/label/xsl:apply-templates" x="242" y="28"/>
				<block path="html/body/div/table/tr[1]/td[1]/label/xsl:apply-templates" x="202" y="28"/>
				<block path="html/body/div/table/tr[2]/td/label/xsl:apply-templates" x="162" y="28"/>
				<block path="html/body/div/table/tr[2]/td[1]/label/xsl:apply-templates" x="122" y="28"/>
				<block path="html/body/div/table/tr[3]/td/label/xsl:apply-templates" x="82" y="28"/>
				<block path="html/body/div/table/tr[3]/td[1]/label/xsl:apply-templates" x="42" y="28"/>
				<block path="html/body/div/table/tr[4]/td/label/xsl:apply-templates" x="322" y="28"/>
				<block path="html/body/div/table/tr[4]/td[1]/label/xsl:apply-templates" x="322" y="28"/>
				<block path="html/body/div/table/tr[5]/td/label/xsl:apply-templates" x="322" y="28"/>
				<block path="html/body/div/table/tr[5]/td[1]/label/xsl:apply-templates" x="322" y="28"/>
				<block path="html/body/div/table/tr[6]/td/label/xsl:apply-templates" x="322" y="28"/>
				<block path="html/body/div/table/tr[6]/td[1]/label/xsl:apply-templates" x="322" y="28"/>
				<block path="html/body/div/table/tr[7]/td/label/xsl:apply-templates" x="322" y="28"/>
				<block path="html/body/table/xsl:apply-templates" x="322" y="28"/>
			</template>
		</MapperBlockPosition>
		<TemplateContext></TemplateContext>
		<MapperFilter side="source"></MapperFilter>
	</MapperMetaTag>
</metaInformation>
-->