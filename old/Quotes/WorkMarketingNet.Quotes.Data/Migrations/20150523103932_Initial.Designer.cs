using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Metadata.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using WorkMarketingNet.Quotes.Data.EntityFramework;

namespace WorkMarketingNet.Quotes.Data.Migrations
{
    [ContextType(typeof(QuotesContext))]
    partial class Initial
    {
        public override string Id
        {
            get { return "20150523103932_Initial"; }
        }
        
        public override string ProductVersion
        {
            get { return "7.0.0-beta4-12943"; }
        }
        
        public override IModel Target
        {
            get
            {
                var builder = new BasicModelBuilder()
                    .Annotation("SqlServer:ValueGeneration", "Sequence");
                
                builder.Entity("WorkMarketingNet.Quotes.Core.Models.Quote", b =>
                    {
                        b.Property<string>("Body")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<Guid>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<string>("Slug")
                            .Annotation("OriginalValueIndex", 2);
                        b.Property<int?>("SourceId")
                            .Annotation("OriginalValueIndex", 3)
                            .Annotation("ShadowIndex", 0);
                        b.Key("Id");
                    });
                
                builder.Entity("WorkMarketingNet.Quotes.Core.Models.Source", b =>
                    {
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 0)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<string>("Image")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<string>("Name")
                            .Annotation("OriginalValueIndex", 2);
                        b.Key("Id");
                    });
                
                builder.Entity("WorkMarketingNet.Quotes.Core.Models.Quote", b =>
                    {
                        b.ForeignKey("WorkMarketingNet.Quotes.Core.Models.Source", "SourceId");
                    });
                
                return builder.Model;
            }
        }
    }
}
