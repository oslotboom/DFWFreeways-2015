<?xml version="1.0" encoding="utf-8"?>

<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:param name="imagePath"/>


  <xsl:template match="maps/info">
    <br></br>
    <div class="orp_main_div" >
      <div class="orp_info">
        <xsl:value-of select="."/>
      </div>
    </div>
    <br></br>
  </xsl:template>

	<xsl:template match="maps/map">
		<br></br>
		<div class="orp_main_div" >
			<table class="orp_table">
				<tr>
					<xsl:apply-templates select="cover" />
					<td valign="top" class="orp_td">
						<xsl:apply-templates select="text"/>
					</td>
				</tr>
			</table>
		</div>
		<br></br>

	</xsl:template>

	<xsl:template match="cover">
		<xsl:choose>
			<xsl:when test="imageLarge">
				<td valign="top" class="orp_td">
					<a target="_blank">
						<xsl:attribute name="href">
							<xsl:copy-of select="$imagePath" />
							<xsl:value-of select="imageLarge"/>
						</xsl:attribute>
						<!-- assume there is a thumbnail if there is a large file -->
						<img>
							<xsl:attribute name="src">
								<xsl:copy-of select="$imagePath" />
								<xsl:value-of select="imageThumbnail"/>
							</xsl:attribute>
							<xsl:attribute name="alt">
								<xsl:text>Map Cover</xsl:text>
							</xsl:attribute>
							<xsl:attribute name="border">
								<xsl:text>0</xsl:text>
							</xsl:attribute>
						</img>
					</a>
				</td>
			</xsl:when>

			<xsl:otherwise>
				<xsl:if test="imageThumbnail">
					<td class="orp_td" valign="top">
						<img>
							<xsl:attribute name="src">
								<xsl:copy-of select="$imagePath" />
								<xsl:value-of select="imageThumbnail"/>
							</xsl:attribute>
							<xsl:attribute name="alt">
								<xsl:text>Map Cover</xsl:text>
							</xsl:attribute>
						</img>					
					</td>
				</xsl:if>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	
	
	
<xsl:template match="text">
	<div class="orp_Header">
		<xsl:value-of select="title"/>
		<xsl:if test="legendFile">
			<a target="_blank">
				<xsl:attribute name="href">
					<xsl:copy-of select="$imagePath" />
					<xsl:value-of select="legendFile"/>
				</xsl:attribute>
				<xsl:attribute name="onmouseover">
					<xsl:text>this.className='orp_LinkLegendMouseOver'</xsl:text>
				</xsl:attribute>
				<xsl:attribute name="onmouseout">
					<xsl:text>this.className='orp_LinkLegend'</xsl:text>
				</xsl:attribute>
				<xsl:attribute name="class">
					<xsl:text>orp_LinkLegend</xsl:text>
				</xsl:attribute>
				<xsl:text>Legend</xsl:text>
			</a>
		</xsl:if>
	</div>
	<xsl:apply-templates select="description"></xsl:apply-templates>
	<xsl:apply-templates select="items"></xsl:apply-templates>
</xsl:template>

	<xsl:template match="description">
		<div class="orp_Description">
			<xsl:value-of select="."/>
		</div>
		
	</xsl:template>


	<xsl:template match="items">
		<table border="0" cellpadding="0" cellspacing="0" class="orp_subTable">
			<xsl:apply-templates select="item"></xsl:apply-templates>
			
		</table>
		
	</xsl:template>

	<xsl:template match="item">
		<tr>
			<td valign="top" width="145px">
				<xsl:value-of select="name"/>	
			</td>
			<td valign="top">
				<xsl:apply-templates select="links/link"></xsl:apply-templates>
			</td>
			<td valign="top">
				<xsl:value-of select="description"/>
			</td>
		</tr>
		
	</xsl:template>

	<xsl:template match="links/link">
		<a target="_blank">
			<xsl:attribute name="href">
				<xsl:copy-of select="$imagePath" />
				<xsl:value-of select="."/>
			</xsl:attribute>
			<xsl:attribute name="style">
				<xsl:text>font-family: arial, sans-serif</xsl:text>
			</xsl:attribute>
			<xsl:value-of select="@text"/>
		</a>
		<xsl:text>&#160;&#160;</xsl:text>
	</xsl:template>
	
</xsl:stylesheet> 

