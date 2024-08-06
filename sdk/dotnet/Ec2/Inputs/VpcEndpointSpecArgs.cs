// *** WARNING: this file was generated by pulumi-gen-awsx. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Awsx.Ec2.Inputs
{

    /// <summary>
    /// Provides a VPC Endpoint resource.
    /// 
    /// &gt; **NOTE on VPC Endpoints and VPC Endpoint Associations:** The provider provides both standalone VPC Endpoint Associations for
    /// Route Tables - (an association between a VPC endpoint and a single `route_table_id`),
    /// Security Groups - (an association between a VPC endpoint and a single `security_group_id`),
    /// and Subnets - (an association between a VPC endpoint and a single `subnet_id`) and
    /// a VPC Endpoint resource with `route_table_ids` and `subnet_ids` attributes.
    /// Do not use the same resource ID in both a VPC Endpoint resource and a VPC Endpoint Association resource.
    /// Doing so will cause a conflict of associations and will overwrite the association.
    /// 
    /// ## Example Usage
    /// 
    /// ### Basic
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```typescript
    /// import * as pulumi from "@pulumi/pulumi";
    /// import * as aws from "@pulumi/aws";
    /// 
    /// const s3 = new aws.ec2.VpcEndpoint("s3", {
    ///     vpcId: main.id,
    ///     serviceName: "com.amazonaws.us-west-2.s3",
    /// });
    /// ```
    /// ```python
    /// import pulumi
    /// import pulumi_aws as aws
    /// 
    /// s3 = aws.ec2.VpcEndpoint("s3",
    ///     vpc_id=main["id"],
    ///     service_name="com.amazonaws.us-west-2.s3")
    /// ```
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var s3 = new Aws.Ec2.VpcEndpoint("s3", new()
    ///     {
    ///         VpcId = main.Id,
    ///         ServiceName = "com.amazonaws.us-west-2.s3",
    ///     });
    /// 
    /// });
    /// ```
    /// ```go
    /// package main
    /// 
    /// import (
    /// 	"github.com/pulumi/pulumi-aws/sdk/v6/go/aws/ec2"
    /// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
    /// )
    /// 
    /// func main() {
    /// 	pulumi.Run(func(ctx *pulumi.Context) error {
    /// 		_, err := ec2.NewVpcEndpoint(ctx, "s3", &amp;ec2.VpcEndpointArgs{
    /// 			VpcId:       pulumi.Any(main.Id),
    /// 			ServiceName: pulumi.String("com.amazonaws.us-west-2.s3"),
    /// 		})
    /// 		if err != nil {
    /// 			return err
    /// 		}
    /// 		return nil
    /// 	})
    /// }
    /// ```
    /// ```java
    /// package generated_program;
    /// 
    /// import com.pulumi.Context;
    /// import com.pulumi.Pulumi;
    /// import com.pulumi.core.Output;
    /// import com.pulumi.aws.ec2.VpcEndpoint;
    /// import com.pulumi.aws.ec2.VpcEndpointArgs;
    /// import java.util.List;
    /// import java.util.ArrayList;
    /// import java.util.Map;
    /// import java.io.File;
    /// import java.nio.file.Files;
    /// import java.nio.file.Paths;
    /// 
    /// public class App {
    ///     public static void main(String[] args) {
    ///         Pulumi.run(App::stack);
    ///     }
    /// 
    ///     public static void stack(Context ctx) {
    ///         var s3 = new VpcEndpoint("s3", VpcEndpointArgs.builder()
    ///             .vpcId(main.id())
    ///             .serviceName("com.amazonaws.us-west-2.s3")
    ///             .build());
    /// 
    ///     }
    /// }
    /// ```
    /// ```yaml
    /// resources:
    ///   s3:
    ///     type: aws:ec2:VpcEndpoint
    ///     properties:
    ///       vpcId: ${main.id}
    ///       serviceName: com.amazonaws.us-west-2.s3
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ### Basic w/ Tags
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```typescript
    /// import * as pulumi from "@pulumi/pulumi";
    /// import * as aws from "@pulumi/aws";
    /// 
    /// const s3 = new aws.ec2.VpcEndpoint("s3", {
    ///     vpcId: main.id,
    ///     serviceName: "com.amazonaws.us-west-2.s3",
    ///     tags: {
    ///         Environment: "test",
    ///     },
    /// });
    /// ```
    /// ```python
    /// import pulumi
    /// import pulumi_aws as aws
    /// 
    /// s3 = aws.ec2.VpcEndpoint("s3",
    ///     vpc_id=main["id"],
    ///     service_name="com.amazonaws.us-west-2.s3",
    ///     tags={
    ///         "Environment": "test",
    ///     })
    /// ```
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var s3 = new Aws.Ec2.VpcEndpoint("s3", new()
    ///     {
    ///         VpcId = main.Id,
    ///         ServiceName = "com.amazonaws.us-west-2.s3",
    ///         Tags = 
    ///         {
    ///             { "Environment", "test" },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// ```go
    /// package main
    /// 
    /// import (
    /// 	"github.com/pulumi/pulumi-aws/sdk/v6/go/aws/ec2"
    /// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
    /// )
    /// 
    /// func main() {
    /// 	pulumi.Run(func(ctx *pulumi.Context) error {
    /// 		_, err := ec2.NewVpcEndpoint(ctx, "s3", &amp;ec2.VpcEndpointArgs{
    /// 			VpcId:       pulumi.Any(main.Id),
    /// 			ServiceName: pulumi.String("com.amazonaws.us-west-2.s3"),
    /// 			Tags: pulumi.StringMap{
    /// 				"Environment": pulumi.String("test"),
    /// 			},
    /// 		})
    /// 		if err != nil {
    /// 			return err
    /// 		}
    /// 		return nil
    /// 	})
    /// }
    /// ```
    /// ```java
    /// package generated_program;
    /// 
    /// import com.pulumi.Context;
    /// import com.pulumi.Pulumi;
    /// import com.pulumi.core.Output;
    /// import com.pulumi.aws.ec2.VpcEndpoint;
    /// import com.pulumi.aws.ec2.VpcEndpointArgs;
    /// import java.util.List;
    /// import java.util.ArrayList;
    /// import java.util.Map;
    /// import java.io.File;
    /// import java.nio.file.Files;
    /// import java.nio.file.Paths;
    /// 
    /// public class App {
    ///     public static void main(String[] args) {
    ///         Pulumi.run(App::stack);
    ///     }
    /// 
    ///     public static void stack(Context ctx) {
    ///         var s3 = new VpcEndpoint("s3", VpcEndpointArgs.builder()
    ///             .vpcId(main.id())
    ///             .serviceName("com.amazonaws.us-west-2.s3")
    ///             .tags(Map.of("Environment", "test"))
    ///             .build());
    /// 
    ///     }
    /// }
    /// ```
    /// ```yaml
    /// resources:
    ///   s3:
    ///     type: aws:ec2:VpcEndpoint
    ///     properties:
    ///       vpcId: ${main.id}
    ///       serviceName: com.amazonaws.us-west-2.s3
    ///       tags:
    ///         Environment: test
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ### Interface Endpoint Type
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```typescript
    /// import * as pulumi from "@pulumi/pulumi";
    /// import * as aws from "@pulumi/aws";
    /// 
    /// const ec2 = new aws.ec2.VpcEndpoint("ec2", {
    ///     vpcId: main.id,
    ///     serviceName: "com.amazonaws.us-west-2.ec2",
    ///     vpcEndpointType: "Interface",
    ///     securityGroupIds: [sg1.id],
    ///     privateDnsEnabled: true,
    /// });
    /// ```
    /// ```python
    /// import pulumi
    /// import pulumi_aws as aws
    /// 
    /// ec2 = aws.ec2.VpcEndpoint("ec2",
    ///     vpc_id=main["id"],
    ///     service_name="com.amazonaws.us-west-2.ec2",
    ///     vpc_endpoint_type="Interface",
    ///     security_group_ids=[sg1["id"]],
    ///     private_dns_enabled=True)
    /// ```
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var ec2 = new Aws.Ec2.VpcEndpoint("ec2", new()
    ///     {
    ///         VpcId = main.Id,
    ///         ServiceName = "com.amazonaws.us-west-2.ec2",
    ///         VpcEndpointType = "Interface",
    ///         SecurityGroupIds = new[]
    ///         {
    ///             sg1.Id,
    ///         },
    ///         PrivateDnsEnabled = true,
    ///     });
    /// 
    /// });
    /// ```
    /// ```go
    /// package main
    /// 
    /// import (
    /// 	"github.com/pulumi/pulumi-aws/sdk/v6/go/aws/ec2"
    /// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
    /// )
    /// 
    /// func main() {
    /// 	pulumi.Run(func(ctx *pulumi.Context) error {
    /// 		_, err := ec2.NewVpcEndpoint(ctx, "ec2", &amp;ec2.VpcEndpointArgs{
    /// 			VpcId:           pulumi.Any(main.Id),
    /// 			ServiceName:     pulumi.String("com.amazonaws.us-west-2.ec2"),
    /// 			VpcEndpointType: pulumi.String("Interface"),
    /// 			SecurityGroupIds: pulumi.StringArray{
    /// 				sg1.Id,
    /// 			},
    /// 			PrivateDnsEnabled: pulumi.Bool(true),
    /// 		})
    /// 		if err != nil {
    /// 			return err
    /// 		}
    /// 		return nil
    /// 	})
    /// }
    /// ```
    /// ```java
    /// package generated_program;
    /// 
    /// import com.pulumi.Context;
    /// import com.pulumi.Pulumi;
    /// import com.pulumi.core.Output;
    /// import com.pulumi.aws.ec2.VpcEndpoint;
    /// import com.pulumi.aws.ec2.VpcEndpointArgs;
    /// import java.util.List;
    /// import java.util.ArrayList;
    /// import java.util.Map;
    /// import java.io.File;
    /// import java.nio.file.Files;
    /// import java.nio.file.Paths;
    /// 
    /// public class App {
    ///     public static void main(String[] args) {
    ///         Pulumi.run(App::stack);
    ///     }
    /// 
    ///     public static void stack(Context ctx) {
    ///         var ec2 = new VpcEndpoint("ec2", VpcEndpointArgs.builder()
    ///             .vpcId(main.id())
    ///             .serviceName("com.amazonaws.us-west-2.ec2")
    ///             .vpcEndpointType("Interface")
    ///             .securityGroupIds(sg1.id())
    ///             .privateDnsEnabled(true)
    ///             .build());
    /// 
    ///     }
    /// }
    /// ```
    /// ```yaml
    /// resources:
    ///   ec2:
    ///     type: aws:ec2:VpcEndpoint
    ///     properties:
    ///       vpcId: ${main.id}
    ///       serviceName: com.amazonaws.us-west-2.ec2
    ///       vpcEndpointType: Interface
    ///       securityGroupIds:
    ///         - ${sg1.id}
    ///       privateDnsEnabled: true
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ### Interface Endpoint Type with User-Defined IP Address
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```typescript
    /// import * as pulumi from "@pulumi/pulumi";
    /// import * as aws from "@pulumi/aws";
    /// 
    /// const ec2 = new aws.ec2.VpcEndpoint("ec2", {
    ///     vpcId: example.id,
    ///     serviceName: "com.amazonaws.us-west-2.ec2",
    ///     vpcEndpointType: "Interface",
    ///     subnetConfigurations: [
    ///         {
    ///             ipv4: "10.0.1.10",
    ///             subnetId: example1.id,
    ///         },
    ///         {
    ///             ipv4: "10.0.2.10",
    ///             subnetId: example2.id,
    ///         },
    ///     ],
    ///     subnetIds: [
    ///         example1.id,
    ///         example2.id,
    ///     ],
    /// });
    /// ```
    /// ```python
    /// import pulumi
    /// import pulumi_aws as aws
    /// 
    /// ec2 = aws.ec2.VpcEndpoint("ec2",
    ///     vpc_id=example["id"],
    ///     service_name="com.amazonaws.us-west-2.ec2",
    ///     vpc_endpoint_type="Interface",
    ///     subnet_configurations=[
    ///         {
    ///             "ipv4": "10.0.1.10",
    ///             "subnet_id": example1["id"],
    ///         },
    ///         {
    ///             "ipv4": "10.0.2.10",
    ///             "subnet_id": example2["id"],
    ///         },
    ///     ],
    ///     subnet_ids=[
    ///         example1["id"],
    ///         example2["id"],
    ///     ])
    /// ```
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var ec2 = new Aws.Ec2.VpcEndpoint("ec2", new()
    ///     {
    ///         VpcId = example.Id,
    ///         ServiceName = "com.amazonaws.us-west-2.ec2",
    ///         VpcEndpointType = "Interface",
    ///         SubnetConfigurations = new[]
    ///         {
    ///             new Aws.Ec2.Inputs.VpcEndpointSubnetConfigurationArgs
    ///             {
    ///                 Ipv4 = "10.0.1.10",
    ///                 SubnetId = example1.Id,
    ///             },
    ///             new Aws.Ec2.Inputs.VpcEndpointSubnetConfigurationArgs
    ///             {
    ///                 Ipv4 = "10.0.2.10",
    ///                 SubnetId = example2.Id,
    ///             },
    ///         },
    ///         SubnetIds = new[]
    ///         {
    ///             example1.Id,
    ///             example2.Id,
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// ```go
    /// package main
    /// 
    /// import (
    /// 	"github.com/pulumi/pulumi-aws/sdk/v6/go/aws/ec2"
    /// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
    /// )
    /// 
    /// func main() {
    /// 	pulumi.Run(func(ctx *pulumi.Context) error {
    /// 		_, err := ec2.NewVpcEndpoint(ctx, "ec2", &amp;ec2.VpcEndpointArgs{
    /// 			VpcId:           pulumi.Any(example.Id),
    /// 			ServiceName:     pulumi.String("com.amazonaws.us-west-2.ec2"),
    /// 			VpcEndpointType: pulumi.String("Interface"),
    /// 			SubnetConfigurations: ec2.VpcEndpointSubnetConfigurationArray{
    /// 				&amp;ec2.VpcEndpointSubnetConfigurationArgs{
    /// 					Ipv4:     pulumi.String("10.0.1.10"),
    /// 					SubnetId: pulumi.Any(example1.Id),
    /// 				},
    /// 				&amp;ec2.VpcEndpointSubnetConfigurationArgs{
    /// 					Ipv4:     pulumi.String("10.0.2.10"),
    /// 					SubnetId: pulumi.Any(example2.Id),
    /// 				},
    /// 			},
    /// 			SubnetIds: pulumi.StringArray{
    /// 				example1.Id,
    /// 				example2.Id,
    /// 			},
    /// 		})
    /// 		if err != nil {
    /// 			return err
    /// 		}
    /// 		return nil
    /// 	})
    /// }
    /// ```
    /// ```java
    /// package generated_program;
    /// 
    /// import com.pulumi.Context;
    /// import com.pulumi.Pulumi;
    /// import com.pulumi.core.Output;
    /// import com.pulumi.aws.ec2.VpcEndpoint;
    /// import com.pulumi.aws.ec2.VpcEndpointArgs;
    /// import com.pulumi.aws.ec2.inputs.VpcEndpointSubnetConfigurationArgs;
    /// import java.util.List;
    /// import java.util.ArrayList;
    /// import java.util.Map;
    /// import java.io.File;
    /// import java.nio.file.Files;
    /// import java.nio.file.Paths;
    /// 
    /// public class App {
    ///     public static void main(String[] args) {
    ///         Pulumi.run(App::stack);
    ///     }
    /// 
    ///     public static void stack(Context ctx) {
    ///         var ec2 = new VpcEndpoint("ec2", VpcEndpointArgs.builder()
    ///             .vpcId(example.id())
    ///             .serviceName("com.amazonaws.us-west-2.ec2")
    ///             .vpcEndpointType("Interface")
    ///             .subnetConfigurations(            
    ///                 VpcEndpointSubnetConfigurationArgs.builder()
    ///                     .ipv4("10.0.1.10")
    ///                     .subnetId(example1.id())
    ///                     .build(),
    ///                 VpcEndpointSubnetConfigurationArgs.builder()
    ///                     .ipv4("10.0.2.10")
    ///                     .subnetId(example2.id())
    ///                     .build())
    ///             .subnetIds(            
    ///                 example1.id(),
    ///                 example2.id())
    ///             .build());
    /// 
    ///     }
    /// }
    /// ```
    /// ```yaml
    /// resources:
    ///   ec2:
    ///     type: aws:ec2:VpcEndpoint
    ///     properties:
    ///       vpcId: ${example.id}
    ///       serviceName: com.amazonaws.us-west-2.ec2
    ///       vpcEndpointType: Interface
    ///       subnetConfigurations:
    ///         - ipv4: 10.0.1.10
    ///           subnetId: ${example1.id}
    ///         - ipv4: 10.0.2.10
    ///           subnetId: ${example2.id}
    ///       subnetIds:
    ///         - ${example1.id}
    ///         - ${example2.id}
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ### Gateway Load Balancer Endpoint Type
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```typescript
    /// import * as pulumi from "@pulumi/pulumi";
    /// import * as aws from "@pulumi/aws";
    /// 
    /// const current = aws.getCallerIdentity({});
    /// const example = new aws.ec2.VpcEndpointService("example", {
    ///     acceptanceRequired: false,
    ///     allowedPrincipals: [current.then(current =&gt; current.arn)],
    ///     gatewayLoadBalancerArns: [exampleAwsLb.arn],
    /// });
    /// const exampleVpcEndpoint = new aws.ec2.VpcEndpoint("example", {
    ///     serviceName: example.serviceName,
    ///     subnetIds: [exampleAwsSubnet.id],
    ///     vpcEndpointType: example.serviceType,
    ///     vpcId: exampleAwsVpc.id,
    /// });
    /// ```
    /// ```python
    /// import pulumi
    /// import pulumi_aws as aws
    /// 
    /// current = aws.get_caller_identity()
    /// example = aws.ec2.VpcEndpointService("example",
    ///     acceptance_required=False,
    ///     allowed_principals=[current.arn],
    ///     gateway_load_balancer_arns=[example_aws_lb["arn"]])
    /// example_vpc_endpoint = aws.ec2.VpcEndpoint("example",
    ///     service_name=example.service_name,
    ///     subnet_ids=[example_aws_subnet["id"]],
    ///     vpc_endpoint_type=example.service_type,
    ///     vpc_id=example_aws_vpc["id"])
    /// ```
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Aws = Pulumi.Aws;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var current = Aws.GetCallerIdentity.Invoke();
    /// 
    ///     var example = new Aws.Ec2.VpcEndpointService("example", new()
    ///     {
    ///         AcceptanceRequired = false,
    ///         AllowedPrincipals = new[]
    ///         {
    ///             current.Apply(getCallerIdentityResult =&gt; getCallerIdentityResult.Arn),
    ///         },
    ///         GatewayLoadBalancerArns = new[]
    ///         {
    ///             exampleAwsLb.Arn,
    ///         },
    ///     });
    /// 
    ///     var exampleVpcEndpoint = new Aws.Ec2.VpcEndpoint("example", new()
    ///     {
    ///         ServiceName = example.ServiceName,
    ///         SubnetIds = new[]
    ///         {
    ///             exampleAwsSubnet.Id,
    ///         },
    ///         VpcEndpointType = example.ServiceType,
    ///         VpcId = exampleAwsVpc.Id,
    ///     });
    /// 
    /// });
    /// ```
    /// ```go
    /// package main
    /// 
    /// import (
    /// 	"github.com/pulumi/pulumi-aws/sdk/v6/go/aws"
    /// 	"github.com/pulumi/pulumi-aws/sdk/v6/go/aws/ec2"
    /// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
    /// )
    /// 
    /// func main() {
    /// 	pulumi.Run(func(ctx *pulumi.Context) error {
    /// 		current, err := aws.GetCallerIdentity(ctx, nil, nil)
    /// 		if err != nil {
    /// 			return err
    /// 		}
    /// 		example, err := ec2.NewVpcEndpointService(ctx, "example", &amp;ec2.VpcEndpointServiceArgs{
    /// 			AcceptanceRequired: pulumi.Bool(false),
    /// 			AllowedPrincipals: pulumi.StringArray{
    /// 				pulumi.String(current.Arn),
    /// 			},
    /// 			GatewayLoadBalancerArns: pulumi.StringArray{
    /// 				exampleAwsLb.Arn,
    /// 			},
    /// 		})
    /// 		if err != nil {
    /// 			return err
    /// 		}
    /// 		_, err = ec2.NewVpcEndpoint(ctx, "example", &amp;ec2.VpcEndpointArgs{
    /// 			ServiceName: example.ServiceName,
    /// 			SubnetIds: pulumi.StringArray{
    /// 				exampleAwsSubnet.Id,
    /// 			},
    /// 			VpcEndpointType: example.ServiceType,
    /// 			VpcId:           pulumi.Any(exampleAwsVpc.Id),
    /// 		})
    /// 		if err != nil {
    /// 			return err
    /// 		}
    /// 		return nil
    /// 	})
    /// }
    /// ```
    /// ```java
    /// package generated_program;
    /// 
    /// import com.pulumi.Context;
    /// import com.pulumi.Pulumi;
    /// import com.pulumi.core.Output;
    /// import com.pulumi.aws.AwsFunctions;
    /// import com.pulumi.aws.inputs.GetCallerIdentityArgs;
    /// import com.pulumi.aws.ec2.VpcEndpointService;
    /// import com.pulumi.aws.ec2.VpcEndpointServiceArgs;
    /// import com.pulumi.aws.ec2.VpcEndpoint;
    /// import com.pulumi.aws.ec2.VpcEndpointArgs;
    /// import java.util.List;
    /// import java.util.ArrayList;
    /// import java.util.Map;
    /// import java.io.File;
    /// import java.nio.file.Files;
    /// import java.nio.file.Paths;
    /// 
    /// public class App {
    ///     public static void main(String[] args) {
    ///         Pulumi.run(App::stack);
    ///     }
    /// 
    ///     public static void stack(Context ctx) {
    ///         final var current = AwsFunctions.getCallerIdentity();
    /// 
    ///         var example = new VpcEndpointService("example", VpcEndpointServiceArgs.builder()
    ///             .acceptanceRequired(false)
    ///             .allowedPrincipals(current.applyValue(getCallerIdentityResult -&gt; getCallerIdentityResult.arn()))
    ///             .gatewayLoadBalancerArns(exampleAwsLb.arn())
    ///             .build());
    /// 
    ///         var exampleVpcEndpoint = new VpcEndpoint("exampleVpcEndpoint", VpcEndpointArgs.builder()
    ///             .serviceName(example.serviceName())
    ///             .subnetIds(exampleAwsSubnet.id())
    ///             .vpcEndpointType(example.serviceType())
    ///             .vpcId(exampleAwsVpc.id())
    ///             .build());
    /// 
    ///     }
    /// }
    /// ```
    /// ```yaml
    /// resources:
    ///   example:
    ///     type: aws:ec2:VpcEndpointService
    ///     properties:
    ///       acceptanceRequired: false
    ///       allowedPrincipals:
    ///         - ${current.arn}
    ///       gatewayLoadBalancerArns:
    ///         - ${exampleAwsLb.arn}
    ///   exampleVpcEndpoint:
    ///     type: aws:ec2:VpcEndpoint
    ///     name: example
    ///     properties:
    ///       serviceName: ${example.serviceName}
    ///       subnetIds:
    ///         - ${exampleAwsSubnet.id}
    ///       vpcEndpointType: ${example.serviceType}
    ///       vpcId: ${exampleAwsVpc.id}
    /// variables:
    ///   current:
    ///     fn::invoke:
    ///       Function: aws:getCallerIdentity
    ///       Arguments: {}
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// Using `pulumi import`, import VPC Endpoints using the VPC endpoint `id`. For example:
    /// 
    /// ```sh
    /// $ pulumi import aws:ec2/vpcEndpoint:VpcEndpoint endpoint1 vpce-3ecf2a57
    /// ```
    /// </summary>
    public sealed class VpcEndpointSpecArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Accept the VPC endpoint (the VPC endpoint and service need to be in the same AWS account).
        /// </summary>
        [Input("autoAccept")]
        public bool? AutoAccept { get; set; }

        /// <summary>
        /// The DNS options for the endpoint. See dns_options below.
        /// </summary>
        [Input("dnsOptions")]
        public Input<Pulumi.Aws.Ec2.Inputs.VpcEndpointDnsOptionsArgs>? DnsOptions { get; set; }

        /// <summary>
        /// The IP address type for the endpoint. Valid values are `ipv4`, `dualstack`, and `ipv6`.
        /// </summary>
        [Input("ipAddressType")]
        public Input<string>? IpAddressType { get; set; }

        /// <summary>
        /// A policy to attach to the endpoint that controls access to the service. This is a JSON formatted string. Defaults to full access. All `Gateway` and some `Interface` endpoints support policies - see the [relevant AWS documentation](https://docs.aws.amazon.com/vpc/latest/userguide/vpc-endpoints-access.html) for more details.
        /// </summary>
        [Input("policy")]
        public Input<string>? Policy { get; set; }

        /// <summary>
        /// Whether or not to associate a private hosted zone with the specified VPC. Applicable for endpoints of type Interface. Defaults to `false`.
        /// </summary>
        [Input("privateDnsEnabled")]
        public bool? PrivateDnsEnabled { get; set; }

        [Input("routeTableIds")]
        private InputList<string>? _routeTableIds;

        /// <summary>
        /// One or more route table IDs. Applicable for endpoints of type `Gateway`.
        /// </summary>
        public InputList<string> RouteTableIds
        {
            get => _routeTableIds ?? (_routeTableIds = new InputList<string>());
            set => _routeTableIds = value;
        }

        [Input("securityGroupIds")]
        private InputList<string>? _securityGroupIds;

        /// <summary>
        /// The ID of one or more security groups to associate with the network interface. Applicable for endpoints of type `Interface`.
        /// If no security groups are specified, the VPC's [default security group](https://docs.aws.amazon.com/vpc/latest/userguide/VPC_SecurityGroups.html#DefaultSecurityGroup) is associated with the endpoint.
        /// </summary>
        public InputList<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new InputList<string>());
            set => _securityGroupIds = value;
        }

        /// <summary>
        /// The service name. For AWS services the service name is usually in the form `com.amazonaws.&lt;region&gt;.&lt;service&gt;` (the SageMaker Notebook service is an exception to this rule, the service name is in the form `aws.sagemaker.&lt;region&gt;.notebook`).
        /// </summary>
        [Input("serviceName", required: true)]
        public string ServiceName { get; set; } = null!;

        [Input("subnetConfigurations")]
        private InputList<Pulumi.Aws.Ec2.Inputs.VpcEndpointSubnetConfigurationArgs>? _subnetConfigurations;

        /// <summary>
        /// Subnet configuration for the endpoint, used to select specific IPv4 and/or IPv6 addresses to the endpoint. See subnet_configuration below.
        /// </summary>
        public InputList<Pulumi.Aws.Ec2.Inputs.VpcEndpointSubnetConfigurationArgs> SubnetConfigurations
        {
            get => _subnetConfigurations ?? (_subnetConfigurations = new InputList<Pulumi.Aws.Ec2.Inputs.VpcEndpointSubnetConfigurationArgs>());
            set => _subnetConfigurations = value;
        }

        [Input("subnetIds")]
        private InputList<string>? _subnetIds;

        /// <summary>
        /// The ID of one or more subnets in which to create a network interface for the endpoint. Applicable for endpoints of type `GatewayLoadBalancer` and `Interface`. Interface type endpoints cannot function without being assigned to a subnet.
        /// </summary>
        public InputList<string> SubnetIds
        {
            get => _subnetIds ?? (_subnetIds = new InputList<string>());
            set => _subnetIds = value;
        }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A map of tags to assign to the resource. If configured with a provider `default_tags` configuration block present, tags with matching keys will overwrite those defined at the provider-level.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The VPC endpoint type, `Gateway`, `GatewayLoadBalancer`, or `Interface`. Defaults to `Gateway`.
        /// </summary>
        [Input("vpcEndpointType")]
        public Input<string>? VpcEndpointType { get; set; }

        public VpcEndpointSpecArgs()
        {
        }
        public static new VpcEndpointSpecArgs Empty => new VpcEndpointSpecArgs();
    }
}
